using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class CP_Menu : Form
    {

        // Constructor
        public CP_Menu()
        {
            InitializeComponent();
        }


        // Eventos para los botones de la barra de navegación
        private void btn_GoUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana usuarios
            CP_Usuarios formularioPrincipal = new CP_Usuarios();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana
            this.Close();
        }

        private void btn_GoEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana empleados
            CP_Empleados formularioPrincipal = new CP_Empleados();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana
            this.Close();
        }

        private void btn_GoProductos_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir productos
            CP_Productos formularioPrincipal = new CP_Productos();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana
            this.Close();
        }

        private void btn_GoProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir proveedores
            CP_Proveedores formularioPrincipal = new CP_Proveedores();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana
            this.Close();
        }

        private void btn_Exit_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Salir al login
            CP_Login formularioPrincipal = new CP_Login();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana
            this.Close();
        }

        private void btn_Realizar_Compra_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Salir al login
            CP_Ventas formularioPrincipal = new CP_Ventas();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana
            this.Close();
        }
    }
}
