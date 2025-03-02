namespace Capa_Presentacion
{
    partial class CP_Menu
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
            this.btn_GoUsuarios = new System.Windows.Forms.Button();
            this.btn_GoEmpleados = new System.Windows.Forms.Button();
            this.btn_GoProveedores = new System.Windows.Forms.Button();
            this.btn_GoProductos = new System.Windows.Forms.Button();
            this.btn_Exit_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GoUsuarios
            // 
            this.btn_GoUsuarios.Location = new System.Drawing.Point(355, 87);
            this.btn_GoUsuarios.Name = "btn_GoUsuarios";
            this.btn_GoUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btn_GoUsuarios.TabIndex = 0;
            this.btn_GoUsuarios.Text = "Usuarios";
            this.btn_GoUsuarios.UseVisualStyleBackColor = true;
            this.btn_GoUsuarios.Click += new System.EventHandler(this.btn_GoUsuarios_Click);
            // 
            // btn_GoEmpleados
            // 
            this.btn_GoEmpleados.Location = new System.Drawing.Point(355, 147);
            this.btn_GoEmpleados.Name = "btn_GoEmpleados";
            this.btn_GoEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btn_GoEmpleados.TabIndex = 1;
            this.btn_GoEmpleados.Text = "Empleados";
            this.btn_GoEmpleados.UseVisualStyleBackColor = true;
            this.btn_GoEmpleados.Click += new System.EventHandler(this.btn_GoEmpleados_Click);
            // 
            // btn_GoProveedores
            // 
            this.btn_GoProveedores.Location = new System.Drawing.Point(355, 205);
            this.btn_GoProveedores.Name = "btn_GoProveedores";
            this.btn_GoProveedores.Size = new System.Drawing.Size(75, 23);
            this.btn_GoProveedores.TabIndex = 2;
            this.btn_GoProveedores.Text = "Proveedores";
            this.btn_GoProveedores.UseVisualStyleBackColor = true;
            this.btn_GoProveedores.Click += new System.EventHandler(this.btn_GoProveedores_Click);
            // 
            // btn_GoProductos
            // 
            this.btn_GoProductos.Location = new System.Drawing.Point(355, 258);
            this.btn_GoProductos.Name = "btn_GoProductos";
            this.btn_GoProductos.Size = new System.Drawing.Size(75, 23);
            this.btn_GoProductos.TabIndex = 3;
            this.btn_GoProductos.Text = "Productos";
            this.btn_GoProductos.UseVisualStyleBackColor = true;
            this.btn_GoProductos.Click += new System.EventHandler(this.btn_GoProductos_Click);
            // 
            // btn_Exit_Menu
            // 
            this.btn_Exit_Menu.Location = new System.Drawing.Point(355, 360);
            this.btn_Exit_Menu.Name = "btn_Exit_Menu";
            this.btn_Exit_Menu.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit_Menu.TabIndex = 4;
            this.btn_Exit_Menu.Text = "Exit";
            this.btn_Exit_Menu.UseVisualStyleBackColor = true;
            this.btn_Exit_Menu.Click += new System.EventHandler(this.btn_Exit_Menu_Click);
            // 
            // CP_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit_Menu);
            this.Controls.Add(this.btn_GoProductos);
            this.Controls.Add(this.btn_GoProveedores);
            this.Controls.Add(this.btn_GoEmpleados);
            this.Controls.Add(this.btn_GoUsuarios);
            this.Name = "CP_Menu";
            this.Text = "CP_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GoUsuarios;
        private System.Windows.Forms.Button btn_GoEmpleados;
        private System.Windows.Forms.Button btn_GoProveedores;
        private System.Windows.Forms.Button btn_GoProductos;
        private System.Windows.Forms.Button btn_Exit_Menu;
    }
}