using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocioo;


namespace Capa_Presentacion
{
    public partial class CP_Ventas : Form
    {
        // Instancias de las clases de negocio
        CN_Productos productos = new CN_Productos();
        CN_Venta ventas = new CN_Venta();
        CN_DetalleVenta detalleVenta = new CN_DetalleVenta();
        DataTable dtVentas = new DataTable();
        decimal totalVenta = 0;

        // Constructor
        public CP_Ventas()
        {
            InitializeComponent();
            LlenarCombo();
            llenar_combo_cantidad();
            ConfigurarDataGridView();

            comboBox_Productos.SelectedIndexChanged += ActualizarTotalPrevio;
            comboBox_Catidad.SelectedIndexChanged += ActualizarTotalPrevio;

            // Actualizar el total al cargar la ventana
            if (comboBox_Productos.Items.Count > 0)
            {
                comboBox_Productos.SelectedIndex = 0;
                comboBox_Catidad.SelectedIndex = 0;
                ActualizarTotalPrevio(null, null);  
            }
        }

        // Método para llenar el ComboBox de cantidad
        private void llenar_combo_cantidad()
        {
            comboBox_Catidad.DataSource = Enumerable.Range(1, 100).ToList();
            comboBox_Catidad.SelectedIndex = 0;
        }

        // Método para llenar el ComboBox de productos
        public void LlenarCombo()
        {
            // Obtener los productos de la base de datos
            var listaProductos = productos.MostrarProductos().AsEnumerable()
                .Select(p => new
                {
                    Id_Producto = p.Field<int>("Id_Producto"),
                    Nombre = p.Field<string>("Nombre"),
                    Descripcion = $"{p.Field<string>("Nombre")} - {p.Field<decimal>("Precio"):C}",
                    Precio = p.Field<decimal>("Precio")
                })
                .ToList();

            comboBox_Productos.DataSource = listaProductos;
            comboBox_Productos.DisplayMember = "Descripcion";
            comboBox_Productos.ValueMember = "Id_Producto";
        }

        // Método para configurar el DataGridView
        private void ConfigurarDataGridView()
        {
            dtVentas.Columns.Add("Id_Producto", typeof(int));
            dtVentas.Columns.Add("Producto", typeof(string));
            dtVentas.Columns.Add("Cantidad", typeof(int));
            dtVentas.Columns.Add("Precio Unitario", typeof(decimal));
            dtVentas.Columns.Add("Subtotal", typeof(decimal));

            dataGridView1.DataSource = dtVentas;
        }

        // Método para actualizar el total previo
        private void ActualizarTotalPrevio(object sender, EventArgs e)
        {
            if (comboBox_Productos.SelectedItem != null && comboBox_Catidad.SelectedItem != null)
            {
                var selectedProduct = (dynamic)comboBox_Productos.SelectedItem;
                decimal precio = selectedProduct.Precio;
                int cantidad = (int)comboBox_Catidad.SelectedItem;
                decimal subtotal = precio * cantidad;

                label_Total_Precio.Text = $"Suma: {subtotal:C}";
            }
        }

        // Método para actualizar el total después de agregar un producto
        private void actualizar_Label_Total()
        {
            if (comboBox_Productos.Items.Count > 0)
            {
                comboBox_Productos.SelectedIndex = 0;
                comboBox_Catidad.SelectedIndex = 0; 
                ActualizarTotalPrevio(null, null);  
            }
        }

        // Bontón para agregar un producto al carrito
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            var selectedProduct = (dynamic)comboBox_Productos.SelectedItem;
            int idProducto = selectedProduct.Id_Producto;
            string nombre = selectedProduct.Nombre;
            decimal precio = selectedProduct.Precio;
            int cantidad = (int)comboBox_Catidad.SelectedItem;
            decimal subtotal = precio * cantidad;

            // Agregar al DataTable
            dtVentas.Rows.Add(idProducto, nombre, cantidad, precio, subtotal);

            // Actualizar el total de la compra
            ActualizarTotal();

            // Reiniciar la suma del producto previo
            actualizar_Label_Total();
        }

        // Método para actualizar el total de la compra
        private void ActualizarTotal()
        {
            // Recalcular desde cero
            totalVenta = dtVentas.AsEnumerable().Sum(row => row.Field<decimal>("Subtotal"));
            label_Total.Text = $"Total Compra: {totalVenta:C}";
        }

        // Botón para realizar la compra
        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if (dtVentas.Rows.Count == 0)
            {
                MessageBox.Show("Agrega productos antes de comprar.");
                return;
            }

            DialogResult result = MessageBox.Show("Está seguro que deseas realizar la compra?", "Confirmado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idEmpleado = CP_Login.IdEmpleadoSesion; // Usar el Id_Empleado de la sesión
                if (idEmpleado == -1)
                {
                    MessageBox.Show("Error: No se ha identificado un empleado válido.");
                    return;
                }

                DateTime fechaVenta = DateTime.Now;
                int cantidadProductos = dtVentas.Rows.Count;

                int idVenta = ventas.Add_Venta(fechaVenta, cantidadProductos, totalVenta, idEmpleado);

                // Si se registró la venta, agregar los detalles
                if (idVenta > 0)
                {
                    foreach (DataRow row in dtVentas.Rows)
                    {
                        int idProducto = Convert.ToInt32(row["Id_Producto"]);
                        int cantidad = Convert.ToInt32(row["Cantidad"]);

                        detalleVenta.Add_Detalle_Venta(cantidad, idProducto, idVenta);
                    }

                    // Limpiar el carrito y mostrar mensaje de éxito
                    MessageBox.Show("Compra realizada correctamente.");
                    dtVentas.Clear();
                    ActualizarTotal();
                }
                else
                {
                    MessageBox.Show("Error al registrar la venta.");
                }
            }
        }

        // Botones para actualizar y eliminar productos del carrito
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int idProducto = Convert.ToInt32(selectedRow.Cells["Id_Producto"].Value);
                string nombreProducto = selectedRow.Cells["Producto"].Value.ToString();
                int cantidad = Convert.ToInt32(selectedRow.Cells["Cantidad"].Value);

                for (int i = 0; i < comboBox_Productos.Items.Count; i++)
                {
                    var item = (dynamic)comboBox_Productos.Items[i];
                    if (item.Id_Producto == idProducto)
                    {
                        comboBox_Productos.SelectedIndex = i;
                        break;
                    }
                }

                comboBox_Catidad.SelectedItem = cantidad;

                int rowIndex = selectedRow.Index;
                dtVentas.Rows.RemoveAt(rowIndex);
                ActualizarTotal();

                MessageBox.Show("Modifica los valores y presiona Agregar para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón para eliminar un producto del carrito
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index; 
                dtVentas.Rows.RemoveAt(rowIndex); 
                ActualizarTotal(); 
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Botón para salir de la ventana de ventas
        private void btn_Exit_Ventas_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Está seguro que deseas salir, si agregaste productos al carrito estos no se guardaran si no realizas la compra", "Confirmado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                CP_Menu formularioPrincipal = new CP_Menu();
                formularioPrincipal.ShowDialog();

                this.Close();
            }
             
        }
    }
}
