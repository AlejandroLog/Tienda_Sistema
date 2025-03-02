namespace Capa_Presentacion
{
    partial class CP_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Usuario_Login = new System.Windows.Forms.TextBox();
            this.txt_Password_Login = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Usuario_Login
            // 
            this.txt_Usuario_Login.Location = new System.Drawing.Point(318, 116);
            this.txt_Usuario_Login.Name = "txt_Usuario_Login";
            this.txt_Usuario_Login.Size = new System.Drawing.Size(100, 20);
            this.txt_Usuario_Login.TabIndex = 0;
            this.txt_Usuario_Login.TextChanged += new System.EventHandler(this.txt_Usuario_Login_TextChanged);
            // 
            // txt_Password_Login
            // 
            this.txt_Password_Login.Location = new System.Drawing.Point(318, 174);
            this.txt_Password_Login.Name = "txt_Password_Login";
            this.txt_Password_Login.Size = new System.Drawing.Size(100, 20);
            this.txt_Password_Login.TabIndex = 1;
            this.txt_Password_Login.TextChanged += new System.EventHandler(this.txt_Password_Login_TextChanged);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(327, 226);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(-1, 2);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(98, 17);
            this.checkBoxPassword.TabIndex = 4;
            this.checkBoxPassword.Text = "Ver contraseña";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged_1);
            this.checkBoxPassword.Click += new System.EventHandler(this.checkBoxPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Login";
            // 
            // CP_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Password_Login);
            this.Controls.Add(this.txt_Usuario_Login);
            this.Name = "CP_Login";
            this.Text = "CP_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario_Login;
        private System.Windows.Forms.TextBox txt_Password_Login;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}