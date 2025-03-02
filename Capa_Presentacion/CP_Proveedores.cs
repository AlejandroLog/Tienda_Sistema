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
    public partial class CP_Proveedores : Form
    {
        CN_Proveedores proveedores = new CN_Proveedores();
        private int ID_Provedor = 0;
        private bool Update = false;
        public CP_Proveedores()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.CP_Proveedores_Load);

        }
        private void CP_Proveedores_Load(object sender, EventArgs e)
        {
            Mostrar_Proveedores();
        }
        private void Mostrar_Proveedores()
        {
            CN_Proveedores proveedor = new CN_Proveedores();
            dGV_Proveedores.DataSource = proveedor.MostrarProveedores();
        }

        private void btn_Agregar_Proveedor_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    // Validar campos obligatorios
                    var camposVacios = new List<string>();

                    if (string.IsNullOrEmpty(txt_Nombre_Proveedor.Text)) camposVacios.Add("Nombre");
                    if (string.IsNullOrEmpty(txt_Apellido_Proveedor.Text)) camposVacios.Add("Apellido");
                    if (string.IsNullOrEmpty(txt_Empresa_Proveedor.Text)) camposVacios.Add("Empresa");
                    if (string.IsNullOrEmpty(txt_Telefono_Proveedor.Text)) camposVacios.Add("Teléfono");
                    if (string.IsNullOrEmpty(txt_Domicilio_Proveedor.Text)) camposVacios.Add("Domicilio");
                    if (string.IsNullOrEmpty(txt_Id_Producto_Proveedor.Text)) camposVacios.Add("ID Producto");

                    if (camposVacios.Count > 0)
                    {
                        MessageBox.Show($"Los siguientes campos son obligatorios:\n{string.Join(", ", camposVacios)}");
                        return;
                    }

                    // Validar teléfono (solo números y 10 dígitos)
                    if (!long.TryParse(txt_Telefono_Proveedor.Text, out _) || txt_Telefono_Proveedor.Text.Length != 10)
                    {
                        MessageBox.Show("El teléfono debe contener exactamente 10 dígitos numéricos.");
                        return;
                    }

                    // Validar ID Producto (debe ser entero positivo)
                    if (!int.TryParse(txt_Id_Producto_Proveedor.Text, out int idProducto) || idProducto <= 0)
                    {
                        MessageBox.Show("El ID del producto debe ser un número entero positivo.");
                        return;
                    }

                    // Llamar al método de negocio que conecta con la capa de datos
                    proveedores.Add_Proveedor(
                        txt_Nombre_Proveedor.Text,
                        txt_Apellido_Proveedor.Text,
                        txt_Empresa_Proveedor.Text,
                        txt_Telefono_Proveedor.Text,
                        txt_Domicilio_Proveedor.Text,
                        true,           // Status activo
                        idProducto       // ID Producto
                    );

                    MessageBox.Show("Proveedor agregado correctamente.");
                    Mostrar_Proveedores();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo agregar el proveedor: {ex.Message}");
                }
            }

            if (Update == true)
            {
                try
                {
                    // Validar campos obligatorios (igual que en el insert)
                    var camposVacios = new List<string>();

                    if (string.IsNullOrEmpty(txt_Nombre_Proveedor.Text)) camposVacios.Add("Nombre");
                    if (string.IsNullOrEmpty(txt_Apellido_Proveedor.Text)) camposVacios.Add("Apellido");
                    if (string.IsNullOrEmpty(txt_Empresa_Proveedor.Text)) camposVacios.Add("Empresa");
                    if (string.IsNullOrEmpty(txt_Telefono_Proveedor.Text)) camposVacios.Add("Teléfono");
                    if (string.IsNullOrEmpty(txt_Domicilio_Proveedor.Text)) camposVacios.Add("Domicilio");
                    if (string.IsNullOrEmpty(txt_Id_Producto_Proveedor.Text)) camposVacios.Add("ID Producto");

                    if (camposVacios.Count > 0)
                    {
                        MessageBox.Show($"Los siguientes campos son obligatorios:\n{string.Join(", ", camposVacios)}");
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

                    // Validar ID Producto (debe ser entero positivo)
                    if (!int.TryParse(txt_Id_Producto_Proveedor.Text, out int idProducto) || idProducto <= 0)
                    {
                        MessageBox.Show("El ID del producto debe ser un número entero positivo.");
                        return;
                    }

                    // Llamar al método de negocio para actualizar
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


        private void btn_Actualizar_Proveedor_Click(object sender, EventArgs e)
        {
            if (dGV_Proveedores.SelectedRows.Count > 0)
            {
                Update = true;
                txt_Nombre_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["nombre"].Value.ToString();
                txt_Apellido_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["apellido"].Value.ToString();
                txt_Empresa_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["empresa"].Value.ToString();
                txt_Telefono_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["telefono"].Value.ToString();
                txt_Domicilio_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["domicilio"].Value.ToString();
                txt_Id_Producto_Proveedor.Text = dGV_Proveedores.CurrentRow.Cells["Id_Producto"].Value.ToString();

                // Capturar el ID del proveedor seleccionado
                ID_Provedor = Convert.ToInt32(dGV_Proveedores.CurrentRow.Cells["Id_Proveedor"].Value);
            }
            else
            {
                MessageBox.Show("Selecciona un proveedor para actualizar.");
            }
        }

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

        private void btn_Exit_Proveedor_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana principal (cambia CP_Usuarios por el formulario que quieras abrir)
            CP_Menu formularioPrincipal = new CP_Menu();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana de login cuando se cierre la principal
            this.Close();
        }

        private void Limpiar()
        {
            txt_Nombre_Proveedor.Clear();
            txt_Apellido_Proveedor.Clear();
            txt_Empresa_Proveedor.Clear();
            txt_Telefono_Proveedor.Clear();
            txt_Domicilio_Proveedor.Clear();
            txt_Id_Producto_Proveedor.Clear();
        }
    }
}
