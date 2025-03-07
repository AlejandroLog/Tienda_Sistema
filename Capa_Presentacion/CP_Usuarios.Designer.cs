namespace Capa_Presentacion
{
    partial class CP_Usuarios
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dGV_Usuarios;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dGV_Usuarios = new System.Windows.Forms.DataGridView();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit_Usuarios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Usuarios
            // 
            this.dGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Usuarios.Location = new System.Drawing.Point(98, 65);
            this.dGV_Usuarios.Name = "dGV_Usuarios";
            this.dGV_Usuarios.Size = new System.Drawing.Size(374, 254);
            this.dGV_Usuarios.TabIndex = 0;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(504, 81);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(174, 20);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(504, 142);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(174, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(538, 210);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(100, 30);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(218, 342);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 30);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Actualizar";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(372, 342);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 30);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Eliminar";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // btn_Exit_Usuarios
            // 
            this.btn_Exit_Usuarios.Location = new System.Drawing.Point(27, 342);
            this.btn_Exit_Usuarios.Name = "btn_Exit_Usuarios";
            this.btn_Exit_Usuarios.Size = new System.Drawing.Size(100, 30);
            this.btn_Exit_Usuarios.TabIndex = 8;
            this.btn_Exit_Usuarios.Text = "Exit";
            this.btn_Exit_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Exit_Usuarios.Click += new System.EventHandler(this.btn_Exit_Usuarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuarios";
            // 
            // CP_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.wp9764014_login_page_wallpapers;
            this.ClientSize = new System.Drawing.Size(700, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Exit_Usuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.dGV_Usuarios);
            this.Name = "CP_Usuarios";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.CP_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit_Usuarios;
        private System.Windows.Forms.Label label3;
    }
}
