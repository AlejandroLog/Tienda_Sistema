using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocioo;

namespace Capa_Presentacion
{
    public partial class CP_Productos : Form
    {
        // Instancia de la clase CN_Productos
        CN_Productos productos = new CN_Productos();
        private int ID_Productos = 0;
        private bool Update = false;

        // Constructor
        public CP_Productos()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.CP_Productos_Load);

        }

        // Evento Load
        private void CP_Productos_Load(object sender, EventArgs e)
        {
            Mostrar_Productos();
        }

        // Método para mostrar productos
        public void Mostrar_Productos()
        {
            CN_Productos productos = new CN_Productos();
            dGV_Productos.DataSource = productos.MostrarProductos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Evento para el botón de agregar producto
        private void btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            // Validar si se va a agregar o actualizar
            if (Update == false)
            {
                try
                {
                    // Validar campos vacíos
                    if (string.IsNullOrEmpty(txt_Nombre_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Descripcion_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Precio_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Costo_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Categoria_Producto.Text))
                    {
                        MessageBox.Show("Los campos son obligatorios, por favor");
                        return;
                    }

                    // Validar precio y costo
                    CultureInfo culture = CultureInfo.InvariantCulture;
                    decimal precio, costo;

                    // Validar precio y . ,
                    if (!decimal.TryParse(txt_Precio_Producto.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, culture, out precio) || precio <= 0)
                    {
                        MessageBox.Show("Ingrese un valor numérico válido y positivo para el precio.");
                        return;
                    }

                    // Validar costo y . ,
                    if (!decimal.TryParse(txt_Costo_Producto.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, culture, out costo) || costo <= 0)
                    {
                        MessageBox.Show("Ingrese un valor numérico válido y positivo para el costo.");
                        return;
                    }

                    // Agregar producto
                    productos.Add_Producto(
                        txt_Nombre_Producto.Text,
                        txt_Descripcion_Producto.Text,
                        precio,
                        costo,
                        txt_Categoria_Producto.Text,
                        true
                    );

                    // Mensaje de éxito
                    MessageBox.Show("El Producto se agregó correctamente");
                    Mostrar_Productos();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    // Mensaje de error
                    MessageBox.Show("No se pudo agregar el Producto: " + ex.Message);
                }
            }

            // Actualizar producto
            if (Update == true)
            {
                try
                {
                    // Validar campos vacíos
                    if (string.IsNullOrEmpty(txt_Nombre_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Descripcion_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Precio_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Costo_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Categoria_Producto.Text))
                    {
                        MessageBox.Show("Los campos son obligatorios, por favor");
                        return;
                    }

                    // Validar precio y costo
                    CultureInfo culture = CultureInfo.InvariantCulture;
                    decimal precio, costo;

                    // Validar precio y . ,
                    if (!decimal.TryParse(txt_Precio_Producto.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, culture, out precio) || precio <= 0)
                    {
                        MessageBox.Show("Ingrese un valor numérico válido y positivo para el precio.");
                        return;
                    }

                    // Validar costo y . ,
                    if (!decimal.TryParse(txt_Costo_Producto.Text.Replace(',', '.'), NumberStyles.AllowDecimalPoint, culture, out costo) || costo <= 0)
                    {
                        MessageBox.Show("Ingrese un valor numérico válido y positivo para el costo.");
                        return;
                    }

                    // Actualizar producto
                    productos.Update_Producto(
                        txt_Nombre_Producto.Text,
                        txt_Descripcion_Producto.Text,
                        precio,
                        costo,
                        txt_Categoria_Producto.Text,
                        true,
                        ID_Productos
                    );

                    // Mensaje de éxito
                    MessageBox.Show("El Producto se actualizó correctamente");
                    Mostrar_Productos();
                    Limpiar();
                    Update = false;
                }
                catch (Exception ex)
                {
                    // Mensaje de error
                    MessageBox.Show("No se pudo actualizar el Producto: " + ex.Message);
                }
            }
        }


        // Método para limpiar campos
        private void Limpiar()
        {
            txt_Nombre_Producto.Clear();
            txt_Descripcion_Producto.Clear();
            txt_Precio_Producto.Clear();
            txt_Costo_Producto.Clear();
            txt_Categoria_Producto.Clear();
        }

        // actualizar producto
        private void btn_Actualizar_Producto_Click(object sender, EventArgs e)
        {
            // Validar si se seleccionó una fila
            if (dGV_Productos.SelectedRows.Count > 0)
            {
                // Actualizar campos
                Update = true;
                txt_Nombre_Producto.Text = dGV_Productos.CurrentRow.Cells["nombre"].Value.ToString();
                txt_Descripcion_Producto.Text = dGV_Productos.CurrentRow.Cells["descripcion"].Value.ToString();
                txt_Precio_Producto.Text = dGV_Productos.CurrentRow.Cells["precio"].Value.ToString();
                txt_Costo_Producto.Text = dGV_Productos.CurrentRow.Cells["costo"].Value.ToString();
                txt_Descripcion_Producto.Text = dGV_Productos.CurrentRow.Cells["descripcion"].Value.ToString();
                txt_Categoria_Producto.Text = dGV_Productos.CurrentRow.Cells["categoria"].Value.ToString();

                // Obtener ID
                ID_Productos = Convert.ToInt32(dGV_Productos.CurrentRow.Cells["Id_Producto"].Value);
            }
            else
            {
                // Mensaje de error
                MessageBox.Show("Selecciona una fila, por favor");
            }
        }

        // eliminar producto
        private void btn_Eliminar_Producto_Click(object sender, EventArgs e)
        {
            // Validar si se seleccionó una fila
            if (dGV_Productos.SelectedRows.Count > 0)
            {
                // Obtener ID
                ID_Productos = Convert.ToInt32(dGV_Productos.CurrentRow.Cells["Id_Producto"].Value);
                productos.Delete_Producto(false, ID_Productos);
                MessageBox.Show("El Producto se eliminó correctamente");
                Mostrar_Productos();
            }
            else
            {
                // Mensaje de error
                MessageBox.Show("Selecciona una fila, por favor");
            }
        }

        // Evento para el botón de salir
        private void btn_Exit_Productos_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la menu
            CP_Menu formularioPrincipal = new CP_Menu();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana
            this.Close();
        }
    }
}
