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
    public partial class CP_Productos : Form
    {
        CN_Productos productos = new CN_Productos();
        private int ID_Productos = 0;
        private bool Update = false;
        public CP_Productos()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.CP_Productos_Load);

        }
        private void CP_Productos_Load(object sender, EventArgs e)
        {
            Mostrar_Productos();
        }

        public void Mostrar_Productos()
        {
            CN_Productos productos = new CN_Productos();
            dGV_Productos.DataSource = productos.MostrarProductos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    // Verificar que no estén vacíos los campos obligatorios
                    if (string.IsNullOrEmpty(txt_Nombre_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Descripcion_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Precio_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Costo_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Categoria_Producto.Text))
                    {
                        MessageBox.Show("Los campos son obligatorios, por favor");
                        return;
                    }

                    // Convertir el valor de precio a decimal y verificar que sea positivo
                    decimal precio;
                    if (!decimal.TryParse(txt_Precio_Producto.Text, out precio) || precio <= 0)
                    {
                        MessageBox.Show("Ingrese un valor numérico válido y positivo para el precio.");
                        return;
                    }

                    // Convertir el valor de costo a decimal y verificar que sea positivo
                    decimal costo;
                    if (!decimal.TryParse(txt_Costo_Producto.Text, out costo) || costo <= 0)
                    {
                        MessageBox.Show("Ingrese un valor numérico válido y positivo para el costo.");
                        return;
                    }

                    // Llamada al método pasando los parámetros correctos
                    productos.Add_Producto(
                        txt_Nombre_Producto.Text,
                        txt_Descripcion_Producto.Text,
                        precio,
                        costo,
                        txt_Categoria_Producto.Text,
                        true
                    );

                    MessageBox.Show("El Producto se agregó correctamente");
                    Mostrar_Productos();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el Producto: " + ex.Message);
                }
            }

            if (Update == true)
            {
                try
                {
                    // Verificar que ninguno de los campos obligatorios esté vacío
                    if (string.IsNullOrEmpty(txt_Nombre_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Descripcion_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Precio_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Costo_Producto.Text) ||
                        string.IsNullOrEmpty(txt_Categoria_Producto.Text))
                    {
                        MessageBox.Show("Los campos son obligatorios, por favor");
                        return;
                    }

                    // Convertir el valor de precio a decimal y verificar que sea positivo
                    decimal precio;
                    if (!decimal.TryParse(txt_Precio_Producto.Text, out precio) || precio <= 0)
                    {
                        MessageBox.Show("Ingrese un valor numérico válido y positivo para el precio.");
                        return;
                    }

                    // Convertir el valor de costo a decimal y verificar que sea positivo
                    decimal costo;
                    if (!decimal.TryParse(txt_Costo_Producto.Text, out costo) || costo <= 0)
                    {
                        MessageBox.Show("Ingrese un valor numérico válido y positivo para el costo.");
                        return;
                    }

                    // Llamada al método para actualizar el producto, pasando los valores convertidos
                    productos.Update_Producto(
                        txt_Nombre_Producto.Text,
                        txt_Descripcion_Producto.Text,
                        precio,
                        costo,
                        txt_Categoria_Producto.Text,
                        true,
                        ID_Productos
                    );

                    MessageBox.Show("El Producto se actualizó correctamente");
                    Mostrar_Productos();
                    Limpiar();
                    Update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar el Producto: " + ex.Message);
                }
            }
        }



        private void Limpiar()
        {
            txt_Nombre_Producto.Clear();
            txt_Descripcion_Producto.Clear();
            txt_Precio_Producto.Clear();
            txt_Costo_Producto.Clear();
            txt_Categoria_Producto.Clear();
        }

        private void btn_Actualizar_Producto_Click(object sender, EventArgs e)
        {
            if (dGV_Productos.SelectedRows.Count > 0)
            {
                Update = true;
                txt_Nombre_Producto.Text = dGV_Productos.CurrentRow.Cells["nombre"].Value.ToString();
                txt_Descripcion_Producto.Text = dGV_Productos.CurrentRow.Cells["descripcion"].Value.ToString();
                txt_Precio_Producto.Text = dGV_Productos.CurrentRow.Cells["precio"].Value.ToString();
                txt_Costo_Producto.Text = dGV_Productos.CurrentRow.Cells["costo"].Value.ToString();
                txt_Descripcion_Producto.Text = dGV_Productos.CurrentRow.Cells["descripcion"].Value.ToString();
                txt_Categoria_Producto.Text = dGV_Productos.CurrentRow.Cells["categoria"].Value.ToString();


                ID_Productos = Convert.ToInt32(dGV_Productos.CurrentRow.Cells["Id_Producto"].Value);
            }
            else
            {
                MessageBox.Show("Selecciona una fila, por favor");
            }
        }

        private void btn_Eliminar_Producto_Click(object sender, EventArgs e)
        {
            if (dGV_Productos.SelectedRows.Count > 0)
            {
                ID_Productos = Convert.ToInt32(dGV_Productos.CurrentRow.Cells["Id_Producto"].Value);
                productos.Delete_Producto(false, ID_Productos);
                MessageBox.Show("El Producto se eliminó correctamente");
                Mostrar_Productos();
            }
            else
            {
                MessageBox.Show("Selecciona una fila, por favor");
            }
        }

        private void btn_Exit_Productos_Click(object sender, EventArgs e)
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
