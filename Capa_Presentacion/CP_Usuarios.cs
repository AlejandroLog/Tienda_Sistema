using System;
using System.Windows.Forms;
using Capa_Negocioo;

namespace Capa_Presentacion
{
    public partial class CP_Usuarios : Form
    {
        CN_Usuarios usuarios = new CN_Usuarios();
        private int ID_Usuarios = 0;
        private bool Update = false;

        public CP_Usuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CP_Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                Mostrar_Usuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void Mostrar_Usuarios()
        {
            try
            {
                CN_Usuarios usuarios = new CN_Usuarios();
                dGV_Usuarios.DataSource = usuarios.MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar usuarios: " + ex.Message);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    if (String.IsNullOrEmpty(txt_Usuario.Text) || String.IsNullOrEmpty(txt_Password.Text))
                    {
                        MessageBox.Show("Los campos son obligatorios, por favor");
                        return;
                    }
                    if (txt_Password.Text.Length < 6)
                    {
                        MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                        return;
                    }

                    usuarios.Add_Usuario(txt_Usuario.Text, txt_Password.Text, true);
                    MessageBox.Show("El Usuario se agregó correctamente");
                    Mostrar_Usuarios();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el Usuario: " + ex.Message);
                }
            }

            if (Update == true)
            {
                try
                {
                    if (txt_Password.Text.Length < 6)
                    {
                        MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                        return;
                    }

                    usuarios.Update_Usuario(txt_Usuario.Text, txt_Password.Text, true, ID_Usuarios);
                    MessageBox.Show("El Usuario se actualizó correctamente");
                    Mostrar_Usuarios();
                    Limpiar();
                    Update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar el usuario: " + ex.Message);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Usuarios.SelectedRows.Count > 0)
                {
                    Update = true;
                    txt_Usuario.Text = dGV_Usuarios.CurrentRow.Cells["usuario"].Value.ToString();
                    txt_Password.Text = dGV_Usuarios.CurrentRow.Cells["password"].Value.ToString();
                    ID_Usuarios = Convert.ToInt32(dGV_Usuarios.CurrentRow.Cells["ID_Usuarios"].Value);
                }
                else
                {
                    MessageBox.Show("Selecciona una fila, por favor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar usuario: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Usuarios.SelectedRows.Count > 0)
                {
                    ID_Usuarios = Convert.ToInt32(dGV_Usuarios.CurrentRow.Cells["ID_Usuarios"].Value);
                    usuarios.Delete_Usuario(false, ID_Usuarios);
                    MessageBox.Show("El Usuario se eliminó correctamente");
                    Mostrar_Usuarios();
                }
                else
                {
                    MessageBox.Show("Selecciona una fila, por favor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txt_Usuario.Clear();
            txt_Password.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Usuarios_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                // Abrir la ventana principal (cambia CP_Usuarios por el formulario que quieras abrir)
                CP_Menu formularioPrincipal = new CP_Menu();
                formularioPrincipal.ShowDialog();

                // Cerrar la ventana de login cuando se cierre la principal
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la ventana: " + ex.Message);
            }
        }
    }
}
