using System;
using System.Windows.Forms;
using Capa_Negocioo;

namespace Capa_Presentacion
{
    public partial class CP_Login : Form
    {
        private CN_Usuarios usuarios = new CN_Usuarios();

        // Constructor
        public CP_Login()
        {
            InitializeComponent();
            txt_Password_Login.PasswordChar = '*';
        }

        private void txt_Usuario_Login_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento para el botón de ingresar
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario_Login.Text;
            string password = txt_Password_Login.Text;


            // Validar usuario
            if (usuarios.ValidarUsuario(usuario, password))
            {
                MessageBox.Show("¡Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ocultar la ventana de login
                this.Hide();

                // Abrir la ventana principal
                CP_Menu formularioPrincipal = new CP_Menu();
                formularioPrincipal.ShowDialog();

                // Cerrar la ventana de login cuando se cierre la principal
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Password_Login_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento para el CheckBox que muestra/oculta la contraseña
        private void checkBoxPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                txt_Password_Login.PasswordChar = '\0';
            }
            else
            {
                txt_Password_Login.PasswordChar = '*';
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPassword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
