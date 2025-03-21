using System;
using System.Linq;
using System.Windows.Forms;
using Capa_Negocioo;

namespace Capa_Presentacion
{
    public partial class CP_Usuarios : Form
    {
        // Instancia de la clase CN_Usuarios
        CN_Usuarios usuarios = new CN_Usuarios();
        private int ID_Usuarios = 0;
        private bool Update = false;

        // Constructor
        public CP_Usuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento Load
        private void CP_Usuarios_Load(object sender, EventArgs e)
        {
            Mostrar_Usuarios();  
        }

        // Método para mostrar usuarios
        private void Mostrar_Usuarios()
        {
            CN_Usuarios usuarios = new CN_Usuarios();
            dGV_Usuarios.DataSource = usuarios.MostrarUsuarios();  
        }

        // Evento para el botón de agregar usuario
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Validar si se va a agregar o actualizar
            if (Update == false)
            {
                try
                {
                    // Validar campos vacíos
                    if (String.IsNullOrEmpty(txt_Usuario.Text) || String.IsNullOrEmpty(txt_Password.Text))
                    {
                        MessageBox.Show("Los campos son obligatorios, por favor");
                        return;
                    }
                   
                    // Validar contraseña
                    if (txt_Password.Text.Length < 6)
                    {
                        MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                        return;
                    }

                    // Agregar usuario
                    usuarios.Add_Usuario(txt_Usuario.Text, txt_Password.Text, true);
                    MessageBox.Show("El Usuario se agregó correctamente");
                    Mostrar_Usuarios();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("No se pudo agregar el Usuario: " + ex.Message);
                }
            }

            // Actualizar
            if (Update == true)
            {
                try
                {
                    // Validar campos vacíos
                    if (String.IsNullOrEmpty(txt_Usuario.Text) || String.IsNullOrEmpty(txt_Password.Text))
                    {
                        MessageBox.Show("Los campos son obligatorios, por favor");
                        return;
                    }
                  
                    // Validar tamaño de contraseña
                    if (txt_Password.Text.Length < 6)
                    {
                        MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                        return;
                    }
                   

                    // Actualizar usuario
                    usuarios.Update_Usuario(txt_Usuario.Text, txt_Password.Text, true, ID_Usuarios);
                    MessageBox.Show("El Usuario se actualizó correctamente");
                    Mostrar_Usuarios();
                    Limpiar();
                    Update = false;
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("No se pudo actualizar el usuario: " + ex.Message);
                }
            }
        }

        // Evento para el botón de actualizar usuario
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay una fila seleccionada
                if (dGV_Usuarios.SelectedRows.Count > 0)
                {
                    // Actualizar campos
                    Update = true;
                    txt_Usuario.Text = dGV_Usuarios.CurrentRow.Cells["usuario"].Value.ToString();
                    txt_Password.Text = dGV_Usuarios.CurrentRow.Cells["password"].Value.ToString();
                    ID_Usuarios = Convert.ToInt32(dGV_Usuarios.CurrentRow.Cells["ID_Usuarios"].Value);
                }
                else
                {
                    // Mensaje de error
                    MessageBox.Show("Selecciona una fila, por favor");
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error al seleccionar usuario: " + ex.Message);
            }
        }

        // Evento para el botón de eliminar usuario
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay una fila seleccionada
                if (dGV_Usuarios.SelectedRows.Count > 0)
                {
                    // Eliminar
                    ID_Usuarios = Convert.ToInt32(dGV_Usuarios.CurrentRow.Cells["ID_Usuarios"].Value);
                    usuarios.Delete_Usuario(false, ID_Usuarios);
                    MessageBox.Show("El Usuario se eliminó correctamente");
                    Mostrar_Usuarios();
                }
                else
                {
                    // Mensaje de error
                    MessageBox.Show("Selecciona una fila, por favor");
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }

        // limpiar campos
        private void Limpiar()
        {
            txt_Usuario.Clear();
            txt_Password.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Evento para el botón de salir
        private void btn_Exit_Usuarios_Click(object sender, EventArgs e)
        {
           this.Hide();
           // Abrir la ventana menu
           CP_Menu formularioPrincipal = new CP_Menu();
           formularioPrincipal.ShowDialog();
           // Cerrar la ventana
           this.Close();  
        }
    }
}
