using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocioo;

namespace Capa_Presentacion
{
    public partial class CP_Empleados : Form
    {
        CN_Empleados empleados = new CN_Empleados();
        CN_Usuarios usuario = new CN_Usuarios();
        private int ID_Empleado = 0;
        private bool Update = false;
        public CP_Empleados()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.CP_Empleados_Load);
            Llenar_Combo();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CP_Empleados_Load(object sender, EventArgs e)
        {
            Mostrar_Empleados();
        }

        private void Mostrar_Empleados()
        {
            CN_Empleados empleado = new CN_Empleados();
            dGV_Empleados.DataSource = empleado.MostrarEmpleados();
        }

        private void Llenar_Combo()
        {
            combo_Usuario.DataSource = usuario.MostrarUsuarios();
            combo_Usuario.DisplayMember = "usuario";
            combo_Usuario.ValueMember = "Id_Usuarios";
                }
        private void btn_Agregar_Empleado_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    // Verificar si algún campo está vacío
                    var camposVacios = new List<string>();

                    if (string.IsNullOrEmpty(txt_Nombre.Text)) camposVacios.Add("Nombre");
                    if (string.IsNullOrEmpty(txt_Apellido.Text)) camposVacios.Add("Apellido");
                    if (string.IsNullOrEmpty(txt_Domicilio.Text)) camposVacios.Add("Domicilio");
                    if (string.IsNullOrEmpty(txt_Fecha_Ing.Text)) camposVacios.Add("Fecha de Ingreso");
                    if (string.IsNullOrEmpty(txt_Rfc.Text)) camposVacios.Add("RFC");
                    if (string.IsNullOrEmpty(txt_Seguro_Social.Text)) camposVacios.Add("Seguro Social");
                    if (string.IsNullOrEmpty(txt_Telefono.Text)) camposVacios.Add("Teléfono");

                    if (camposVacios.Count > 0)
                    {
                        MessageBox.Show($"Los siguientes campos son obligatorios:\n{string.Join(", ", camposVacios)}");
                        return;
                    }

                    // Validaciones de tipo de dato
                    if (!DateTime.TryParse(txt_Fecha_Ing.Text, out DateTime fecha_Ing))
                    {
                        MessageBox.Show("La fecha ingresada no es válida.");
                        return;
                    }
                    if (fecha_Ing == DateTime.MinValue)
                    {
                        MessageBox.Show("La fecha ingresada no es válida.");
                        return;
                    }

                    int idUsuario = Convert.ToInt32(combo_Usuario.SelectedValue);

                    // Validar Teléfono (solo 10 dígitos numéricos)
                    if (txt_Telefono.Text.Length != 10 || !txt_Telefono.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("El teléfono debe contener exactamente 10 dígitos numéricos.");
                        return;
                    }

                    // Validar RFC (12 o 13 caracteres)
                    if (txt_Rfc.Text.Length < 12 || txt_Rfc.Text.Length > 13)
                    {
                        MessageBox.Show("El RFC debe tener 12 o 13 caracteres.");
                        return;
                    }

                    // Validar Seguro Social (11 números)
                    if (txt_Seguro_Social.Text.Length != 11 || !txt_Seguro_Social.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("El Seguro Social debe contener exactamente 11 dígitos numéricos.");
                        return;
                    }

                    // Llamada al procedimiento para agregar empleado
                    empleados.Add_Empleado(
                        txt_Nombre.Text,
                        txt_Apellido.Text,
                        fecha_Ing,
                        txt_Telefono.Text,
                        txt_Domicilio.Text,
                        txt_Rfc.Text,
                        txt_Seguro_Social.Text,
                        true,
                        idUsuario
                    );

                    MessageBox.Show("El usuario se agregó correctamente.");
                    Mostrar_Empleados();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo agregar el empleado: {ex.Message}");
                }
            }

            if (Update == true)
            {
                try
                {
                    // Validar y convertir datos para actualizar
                    if (!DateTime.TryParse(txt_Fecha_Ing.Text, out DateTime fecha_Ing))
                    {
                        MessageBox.Show("La fecha ingresada no es válida.");
                        return;
                    }

                    // Validar Teléfono (solo 10 dígitos numéricos)
                    if (txt_Telefono.Text.Length != 10 || !txt_Telefono.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("El teléfono debe contener exactamente 10 dígitos numéricos.");
                        return;
                    }

                    // Validar RFC (12 o 13 caracteres)
                    if (txt_Rfc.Text.Length < 12 || txt_Rfc.Text.Length > 13)
                    {
                        MessageBox.Show("El RFC debe tener 12 o 13 caracteres.");
                        return;
                    }

                    // Validar Seguro Social (11 números)
                    if (txt_Seguro_Social.Text.Length != 11 || !txt_Seguro_Social.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("El Seguro Social debe contener exactamente 11 dígitos numéricos.");
                        return;
                    }

                    int idUsuario = Convert.ToInt32(combo_Usuario.SelectedValue);

                    // Llamada al procedimiento para actualizar empleado
                    empleados.Update_Empleado(
                        txt_Nombre.Text,
                        txt_Apellido.Text,
                        fecha_Ing,
                        txt_Telefono.Text,
                        txt_Domicilio.Text,
                        txt_Rfc.Text,
                        txt_Seguro_Social.Text,
                        true,
                        ID_Empleado,
                        idUsuario
                    );

                    MessageBox.Show("El Empleado se actualizó correctamente.");
                    Mostrar_Empleados();
                    Limpiar();
                    Update = false; // Regresa a modo agregar
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar el empleado: " + ex.Message);
                }
            }
        }



        private void btn_Actualizar_Empleado_Click(object sender, EventArgs e)
        {
            if (dGV_Empleados.SelectedRows.Count > 0)
            {
                Update = true;
                txt_Nombre.Text = dGV_Empleados.CurrentRow.Cells["nombre"].Value.ToString();
                txt_Apellido.Text = dGV_Empleados.CurrentRow.Cells["apellido"].Value.ToString();
                txt_Fecha_Ing.Text = dGV_Empleados.CurrentRow.Cells["fecha_Ing"].Value.ToString();
                txt_Telefono.Text = dGV_Empleados.CurrentRow.Cells["telefono"].Value.ToString();
                txt_Domicilio.Text = dGV_Empleados.CurrentRow.Cells["domicilio"].Value.ToString();
                txt_Rfc.Text = dGV_Empleados.CurrentRow.Cells["rfc"].Value.ToString();
                txt_Seguro_Social.Text = dGV_Empleados.CurrentRow.Cells["seguro_Social"].Value.ToString();


                // Asigna el ID del empleado para la actualización
                ID_Empleado = Convert.ToInt32(dGV_Empleados.CurrentRow.Cells["Id_Empleados"].Value);
            }
            else
            {
                MessageBox.Show("Selecciona una fila, por favor");
            }
        }


        private void Limpiar()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Domicilio.Clear();
            txt_Rfc.Clear();
            txt_Seguro_Social.Clear();
            txt_Fecha_Ing.Clear();
            txt_Telefono.Clear();
            txt_Id_Usuario.Clear();
        }

        private void btn_Eliminar_Empleado_Click(object sender, EventArgs e)
        {
            if (dGV_Empleados.SelectedRows.Count > 0)
            {
                ID_Empleado = Convert.ToInt32(dGV_Empleados.CurrentRow.Cells["Id_Empleados"].Value);
                empleados.Delete_Empleado(false, ID_Empleado);
                MessageBox.Show("El Empleado se eliminó correctamente");
                Mostrar_Empleados();
            }
            else
            {
                MessageBox.Show("Selecciona una fila, por favor");
            }
        }

        private void btn_Exit_Empleados_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana principal (cambia CP_Usuarios por el formulario que quieras abrir)
            CP_Menu formularioPrincipal = new CP_Menu();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana de login cuando se cierre la principal
            this.Close();
        }

        
    }
}
