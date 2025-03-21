using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Capa_Negocioo;

namespace Capa_Presentacion
{
    public partial class CP_Proveedores : Form
    {
        // Instancias de las clases CN_Proveedores y CN_Productos
        CN_Proveedores proveedores = new CN_Proveedores();
        CN_Productos producto = new CN_Productos();
        private int ID_Provedor = 0;
        private bool Update = false;

        // Constructor
        public CP_Proveedores()
        {
            InitializeComponent();
            Llenar_Combo();
            this.Load += new System.EventHandler(this.CP_Proveedores_Load);
        }

        // Evento Load
        private void CP_Proveedores_Load(object sender, EventArgs e)
        {
            Mostrar_Proveedores();
        }

        // Mostrar proveedores
        private void Mostrar_Proveedores()
        {
            // Instancia de la clase CN_Proveedores
            CN_Proveedores proveedor = new CN_Proveedores();
            dGV_Proveedores.DataSource = proveedor.MostrarProveedores();
        }

        // Llenar combo
        private void Llenar_Combo()
        {
            combo_Producto.DataSource = producto.MostrarProductos();
            combo_Producto.DisplayMember = "nombre";
            combo_Producto.ValueMember = "Id_Producto";
        }

        // Agregar
        private void btn_Agregar_Proveedor_Click(object sender, EventArgs e)
        {
            // Agregar
            if (Update == false)
            {
                try
                {
                    // Validar campos vacíos
                    var camposVacios = new List<string>();
                    if (string.IsNullOrEmpty(txt_Nombre_Proveedor.Text)) camposVacios.Add("Nombre");
                    if (string.IsNullOrEmpty(txt_Apellido_Proveedor.Text)) camposVacios.Add("Apellido");
                    if (string.IsNullOrEmpty(txt_Empresa_Proveedor.Text)) camposVacios.Add("Empresa");
                    if (string.IsNullOrEmpty(txt_Telefono_Proveedor.Text)) camposVacios.Add("Teléfono");
                    if (string.IsNullOrEmpty(txt_Domicilio_Proveedor.Text)) camposVacios.Add("Domicilio");
                    if (combo_Producto.SelectedValue == null) camposVacios.Add("ID Producto");

                    // Validar campos vacíos
                    if (camposVacios.Count > 0)
                    {
                        MessageBox.Show($"Los siguientes campos son obligatorios:\n{string.Join(", ", camposVacios)}");
                        return;
                    }
                    if (!txt_Nombre_Proveedor.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) ||
                         !txt_Apellido_Proveedor.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("El nombre y apellido solo pueden contener letras.");
                        return;
                    }


                    // Validar teléfono (solo números y 10 dígitos)
                    if (!long.TryParse(txt_Telefono_Proveedor.Text, out _) || txt_Telefono_Proveedor.Text.Length != 10)
                    {
                        MessageBox.Show("El teléfono debe contener exactamente 10 dígitos numéricos.");
                        return;
                    }

                    int idProducto = Convert.ToInt32(combo_Producto.SelectedValue);

                    // Agregar proveedor
                    proveedores.Add_Proveedor(
                        txt_Nombre_Proveedor.Text,
                        txt_Apellido_Proveedor.Text,
                        txt_Empresa_Proveedor.Text,
                        txt_Telefono_Proveedor.Text,
                        txt_Domicilio_Proveedor.Text,
                        true,
                        idProducto
                    );

                    // Mensaje de éxito
                    MessageBox.Show("Proveedor agregado correctamente.");
                    Mostrar_Proveedores();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    // Mensaje de error
                    MessageBox.Show($"No se pudo agregar el proveedor: {ex.Message}");
                }
            }

            // Actualizar
            if (Update == true)
            {
                try
                {
                    var camposVacios = new List<string>();

                    if (string.IsNullOrEmpty(txt_Nombre_Proveedor.Text)) camposVacios.Add("Nombre");
                    if (string.IsNullOrEmpty(txt_Apellido_Proveedor.Text)) camposVacios.Add("Apellido");
                    if (string.IsNullOrEmpty(txt_Empresa_Proveedor.Text)) camposVacios.Add("Empresa");
                    if (string.IsNullOrEmpty(txt_Telefono_Proveedor.Text)) camposVacios.Add("Teléfono");
                    if (string.IsNullOrEmpty(txt_Domicilio_Proveedor.Text)) camposVacios.Add("Domicilio");
                    //if (string.IsNullOrEmpty(txt_Id_Producto_Proveedor.Text)) camposVacios.Add("ID Producto");

                    if (camposVacios.Count > 0)
                    {
                        MessageBox.Show($"Los siguientes campos son obligatorios:\n{string.Join(", ", camposVacios)}");
                        return;
                    }

                    if (!txt_Nombre_Proveedor.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) ||
                       !txt_Apellido_Proveedor.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("El nombre y apellido solo pueden contener letras.");
                        return;
                    }


                    if (ID_Provedor == 0)
                    {
                        MessageBox.Show("Selecciona un proveedor antes de actualizar.");
                        return;
                    }

                    // Validar teléfono (solo números y 10 dígitos)
                    if (!long.TryParse(txt_Telefono_Proveedor.Text, out _) || txt_Telefono_Proveedor.Text.Length != 10)
                    {
                        MessageBox.Show("El teléfono debe contener exactamente 10 dígitos numéricos.");
                        return;
                    }

                    int idProducto = Convert.ToInt32(combo_Producto.SelectedValue);

                    // Actualizar proveedor
                    proveedores.Update_Proveedor(
                      txt_Nombre_Proveedor.Text,
                      txt_Apellido_Proveedor.Text,
                      txt_Empresa_Proveedor.Text,
                      txt_Telefono_Proveedor.Text,
                      txt_Domicilio_Proveedor.Text,
                      true,              // Status activo
                      idProducto,
                      ID_Provedor // ID Proveedor
                  );

                    MessageBox.Show("Proveedor actualizado correctamente.");
                    Mostrar_Proveedores();
                    Limpiar();
                    Update = false;  // Regresamos el flag para que el botón vuelva a funcionar como "Agregar"
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo actualizar el proveedor: {ex.Message}");
                }
            }
        }


        // Actualizar
        private void btn_Actualizar_Proveedor_Click(object sender, EventArgs e)
        {
            // Validar si hay una fila seleccionada
            if (dGV_Proveedores.SelectedRows.Count > 0)
            {
                // Actualizar
                Update = true;
                txt_Nombre_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["nombre"].Value.ToString();
                txt_Apellido_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["apellido"].Value.ToString();
                txt_Empresa_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["empresa"].Value.ToString();
                txt_Telefono_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["telefono"].Value.ToString();
                txt_Domicilio_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["domicilio"].Value.ToString();
                //combo_Producto.SelectedValue = dGV_Proveedores.CurrentRow.Cells["Id_Producto"].Value;

                ID_Provedor = Convert.ToInt32(dGV_Proveedores.CurrentRow.Cells["Id_Proveedor"].Value);
            }
            else
            {
                // Mensaje de error
                MessageBox.Show("Selecciona un proveedor para actualizar.");
            }
        }

        // Eliminar
        private void btn_Eliminar_Proveedor_Click(object sender, EventArgs e)
        {
            if (dGV_Proveedores.SelectedRows.Count > 0)
            {
                ID_Provedor = Convert.ToInt32(dGV_Proveedores.CurrentRow.Cells["Id_Proveedor"].Value);
                proveedores.Delete_Proveedor(false, ID_Provedor);
                MessageBox.Show("El Proveedor se eliminó correctamente");
                Mostrar_Proveedores();
            }
            else
            {
                MessageBox.Show("Selecciona una fila, por favor");
            }
        }

        // Salir
        private void btn_Exit_Proveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CP_Menu formularioPrincipal = new CP_Menu();
            formularioPrincipal.ShowDialog();
            this.Close();
        }

        // Limpiar campos
        private void Limpiar()
        {
            txt_Nombre_Proveedor.Clear();
            txt_Apellido_Proveedor.Clear();
            txt_Empresa_Proveedor.Clear();
            txt_Telefono_Proveedor.Clear();
            txt_Domicilio_Proveedor.Clear();
            //combo_Producto.SelectedIndex = -1;
        }
    }
}
