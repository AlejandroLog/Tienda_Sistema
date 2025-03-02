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
        public CP_Menu()
        {
            InitializeComponent();
        }

        private void btn_GoUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana principal (cambia CP_Usuarios por el formulario que quieras abrir)
            CP_Usuarios formularioPrincipal = new CP_Usuarios();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana de login cuando se cierre la principal
            this.Close();
        }

        private void btn_GoEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana principal (cambia CP_Usuarios por el formulario que quieras abrir)
            CP_Empleados formularioPrincipal = new CP_Empleados();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana de login cuando se cierre la principal
            this.Close();
        }

        private void btn_GoProductos_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana principal (cambia CP_Usuarios por el formulario que quieras abrir)
            CP_Productos formularioPrincipal = new CP_Productos();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana de login cuando se cierre la principal
            this.Close();
        }

        private void btn_GoProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana principal (cambia CP_Usuarios por el formulario que quieras abrir)
            CP_Proveedores formularioPrincipal = new CP_Proveedores();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana de login cuando se cierre la principal
            this.Close();
        }

        private void btn_Exit_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abrir la ventana principal (cambia CP_Usuarios por el formulario que quieras abrir)
            CP_Login formularioPrincipal = new CP_Login();
            formularioPrincipal.ShowDialog();

            // Cerrar la ventana de login cuando se cierre la principal
            this.Close();
        }
    }
}
