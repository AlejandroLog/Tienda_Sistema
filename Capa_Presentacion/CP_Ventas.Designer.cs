namespace Capa_Presentacion
{
    partial class CP_Ventas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_Productos = new System.Windows.Forms.ComboBox();
            this.comboBox_Catidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Total_Precio = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.btn_Exit_Ventas = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(268, 394);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Realizar Compra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(609, 271);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar Producto al Carrito";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // comboBox_Productos
            // 
            this.comboBox_Productos.FormattingEnabled = true;
            this.comboBox_Productos.Location = new System.Drawing.Point(617, 82);
            this.comboBox_Productos.Name = "comboBox_Productos";
            this.comboBox_Productos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Productos.TabIndex = 3;
            // 
            // comboBox_Catidad
            // 
            this.comboBox_Catidad.FormattingEnabled = true;
            this.comboBox_Catidad.Location = new System.Drawing.Point(617, 145);
            this.comboBox_Catidad.Name = "comboBox_Catidad";
            this.comboBox_Catidad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Catidad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona el producto que deseas adquirir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecciona la cantidad del Producto";
            // 
            // label_Total_Precio
            // 
            this.label_Total_Precio.AutoSize = true;
            this.label_Total_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total_Precio.Location = new System.Drawing.Point(589, 215);
            this.label_Total_Precio.Name = "label_Total_Precio";
            this.label_Total_Precio.Size = new System.Drawing.Size(60, 20);
            this.label_Total_Precio.TabIndex = 8;
            this.label_Total_Precio.Text = "Suma:";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(245, 367);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(174, 24);
            this.label_Total.TabIndex = 9;
            this.label_Total.Text = "Cantidad a pagar:";
            // 
            // btn_Exit_Ventas
            // 
            this.btn_Exit_Ventas.BackColor = System.Drawing.Color.Red;
            this.btn_Exit_Ventas.Location = new System.Drawing.Point(42, 394);
            this.btn_Exit_Ventas.Name = "btn_Exit_Ventas";
            this.btn_Exit_Ventas.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit_Ventas.TabIndex = 10;
            this.btn_Exit_Ventas.Text = "Exit";
            this.btn_Exit_Ventas.UseVisualStyleBackColor = false;
            this.btn_Exit_Ventas.Click += new System.EventHandler(this.btn_Exit_Ventas_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_Eliminar.Location = new System.Drawing.Point(651, 394);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(100, 23);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Text = "Eliminar Producto";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Actualizar.Location = new System.Drawing.Point(483, 394);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(116, 23);
            this.btn_Actualizar.TabIndex = 12;
            this.btn_Actualizar.Text = "Modificar";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Carrito de Compras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Producto y Cantidad";
            // 
            // CP_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.carritoCompras;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Exit_Ventas);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_Total_Precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Catidad);
            this.Controls.Add(this.comboBox_Productos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CP_Ventas";
            this.Text = "CP_Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_Productos;
        private System.Windows.Forms.ComboBox comboBox_Catidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Total_Precio;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button btn_Exit_Ventas;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}