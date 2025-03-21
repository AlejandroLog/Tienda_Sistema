namespace Capa_Presentacion
{
    partial class CP_Productos
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
            this.dGV_Productos = new System.Windows.Forms.DataGridView();
            this.txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.txt_Descripcion_Producto = new System.Windows.Forms.TextBox();
            this.txt_Precio_Producto = new System.Windows.Forms.TextBox();
            this.txt_Costo_Producto = new System.Windows.Forms.TextBox();
            this.txt_Categoria_Producto = new System.Windows.Forms.TextBox();
            this.btn_Agregar_Producto = new System.Windows.Forms.Button();
            this.btn_Eliminar_Producto = new System.Windows.Forms.Button();
            this.btn_Actualizar_Producto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Exit_Productos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Productos
            // 
            this.dGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Productos.Location = new System.Drawing.Point(27, 72);
            this.dGV_Productos.Name = "dGV_Productos";
            this.dGV_Productos.Size = new System.Drawing.Size(543, 294);
            this.dGV_Productos.TabIndex = 0;
            // 
            // txt_Nombre_Producto
            // 
            this.txt_Nombre_Producto.Location = new System.Drawing.Point(640, 100);
            this.txt_Nombre_Producto.Name = "txt_Nombre_Producto";
            this.txt_Nombre_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre_Producto.TabIndex = 1;
            // 
            // txt_Descripcion_Producto
            // 
            this.txt_Descripcion_Producto.Location = new System.Drawing.Point(640, 149);
            this.txt_Descripcion_Producto.Name = "txt_Descripcion_Producto";
            this.txt_Descripcion_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Descripcion_Producto.TabIndex = 2;
            // 
            // txt_Precio_Producto
            // 
            this.txt_Precio_Producto.Location = new System.Drawing.Point(640, 200);
            this.txt_Precio_Producto.Name = "txt_Precio_Producto";
            this.txt_Precio_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio_Producto.TabIndex = 3;
            // 
            // txt_Costo_Producto
            // 
            this.txt_Costo_Producto.Location = new System.Drawing.Point(640, 254);
            this.txt_Costo_Producto.Name = "txt_Costo_Producto";
            this.txt_Costo_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Costo_Producto.TabIndex = 4;
            // 
            // txt_Categoria_Producto
            // 
            this.txt_Categoria_Producto.Location = new System.Drawing.Point(636, 308);
            this.txt_Categoria_Producto.Name = "txt_Categoria_Producto";
            this.txt_Categoria_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Categoria_Producto.TabIndex = 5;
            // 
            // btn_Agregar_Producto
            // 
            this.btn_Agregar_Producto.Location = new System.Drawing.Point(661, 395);
            this.btn_Agregar_Producto.Name = "btn_Agregar_Producto";
            this.btn_Agregar_Producto.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar_Producto.TabIndex = 6;
            this.btn_Agregar_Producto.Text = "Agregar";
            this.btn_Agregar_Producto.UseVisualStyleBackColor = true;
            this.btn_Agregar_Producto.Click += new System.EventHandler(this.btn_Agregar_Producto_Click);
            // 
            // btn_Eliminar_Producto
            // 
            this.btn_Eliminar_Producto.Location = new System.Drawing.Point(377, 395);
            this.btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            this.btn_Eliminar_Producto.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar_Producto.TabIndex = 7;
            this.btn_Eliminar_Producto.Text = "Eliminar";
            this.btn_Eliminar_Producto.UseVisualStyleBackColor = true;
            this.btn_Eliminar_Producto.Click += new System.EventHandler(this.btn_Eliminar_Producto_Click);
            // 
            // btn_Actualizar_Producto
            // 
            this.btn_Actualizar_Producto.Location = new System.Drawing.Point(201, 395);
            this.btn_Actualizar_Producto.Name = "btn_Actualizar_Producto";
            this.btn_Actualizar_Producto.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar_Producto.TabIndex = 8;
            this.btn_Actualizar_Producto.Text = "Actualizar";
            this.btn_Actualizar_Producto.UseVisualStyleBackColor = true;
            this.btn_Actualizar_Producto.Click += new System.EventHandler(this.btn_Actualizar_Producto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Categoria";
            // 
            // btn_Exit_Productos
            // 
            this.btn_Exit_Productos.BackColor = System.Drawing.Color.Red;
            this.btn_Exit_Productos.Location = new System.Drawing.Point(27, 395);
            this.btn_Exit_Productos.Name = "btn_Exit_Productos";
            this.btn_Exit_Productos.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit_Productos.TabIndex = 14;
            this.btn_Exit_Productos.Text = "Exit";
            this.btn_Exit_Productos.UseVisualStyleBackColor = false;
            this.btn_Exit_Productos.Click += new System.EventHandler(this.btn_Exit_Productos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Productos";
            // 
            // CP_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.wp9764014_login_page_wallpapers;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Exit_Productos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Actualizar_Producto);
            this.Controls.Add(this.btn_Eliminar_Producto);
            this.Controls.Add(this.btn_Agregar_Producto);
            this.Controls.Add(this.txt_Categoria_Producto);
            this.Controls.Add(this.txt_Costo_Producto);
            this.Controls.Add(this.txt_Precio_Producto);
            this.Controls.Add(this.txt_Descripcion_Producto);
            this.Controls.Add(this.txt_Nombre_Producto);
            this.Controls.Add(this.dGV_Productos);
            this.Name = "CP_Productos";
            this.Text = "CP_Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Productos;
        private System.Windows.Forms.TextBox txt_Nombre_Producto;
        private System.Windows.Forms.TextBox txt_Descripcion_Producto;
        private System.Windows.Forms.TextBox txt_Precio_Producto;
        private System.Windows.Forms.TextBox txt_Costo_Producto;
        private System.Windows.Forms.TextBox txt_Categoria_Producto;
        private System.Windows.Forms.Button btn_Agregar_Producto;
        private System.Windows.Forms.Button btn_Eliminar_Producto;
        private System.Windows.Forms.Button btn_Actualizar_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Exit_Productos;
        private System.Windows.Forms.Label label6;
    }
}