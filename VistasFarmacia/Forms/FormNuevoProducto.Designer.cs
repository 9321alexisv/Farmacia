namespace VistasFarmacia.Forms
{
    partial class FormNuevoProducto
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
            labelIngresoProductos = new Label();
            labelProveedor = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelNombre = new Label();
            textBox3 = new TextBox();
            labelPrecioCompra = new Label();
            textBox4 = new TextBox();
            labelPrecioVenta = new Label();
            textBox5 = new TextBox();
            labelStock = new Label();
            buttonSaveClient = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelIngresoProductos
            // 
            labelIngresoProductos.AutoSize = true;
            labelIngresoProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelIngresoProductos.ForeColor = Color.White;
            labelIngresoProductos.Location = new Point(68, 25);
            labelIngresoProductos.Name = "labelIngresoProductos";
            labelIngresoProductos.Size = new Size(249, 32);
            labelIngresoProductos.TabIndex = 1;
            labelIngresoProductos.Text = "Ingreso de Productos";
            // 
            // labelProveedor
            // 
            labelProveedor.AutoSize = true;
            labelProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelProveedor.ForeColor = Color.White;
            labelProveedor.Location = new Point(77, 82);
            labelProveedor.Name = "labelProveedor";
            labelProveedor.Size = new Size(137, 25);
            labelProveedor.TabIndex = 2;
            labelProveedor.Text = "ID Proveedor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 23);
            textBox2.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(77, 138);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(180, 25);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre Producto:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // labelPrecioCompra
            // 
            labelPrecioCompra.AutoSize = true;
            labelPrecioCompra.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelPrecioCompra.ForeColor = Color.White;
            labelPrecioCompra.Location = new Point(77, 191);
            labelPrecioCompra.Name = "labelPrecioCompra";
            labelPrecioCompra.Size = new Size(149, 25);
            labelPrecioCompra.TabIndex = 6;
            labelPrecioCompra.Text = "Precio Compra:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(264, 245);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // labelPrecioVenta
            // 
            labelPrecioVenta.AutoSize = true;
            labelPrecioVenta.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelPrecioVenta.ForeColor = Color.White;
            labelPrecioVenta.Location = new Point(77, 245);
            labelPrecioVenta.Name = "labelPrecioVenta";
            labelPrecioVenta.Size = new Size(129, 25);
            labelPrecioVenta.TabIndex = 8;
            labelPrecioVenta.Text = "Precio Venta:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(264, 301);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(53, 23);
            textBox5.TabIndex = 11;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(77, 299);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(68, 25);
            labelStock.TabIndex = 10;
            labelStock.Text = "Stock:";
            // 
            // buttonSaveClient
            // 
            buttonSaveClient.FlatStyle = FlatStyle.Flat;
            buttonSaveClient.Image = Properties.Resources.ADD;
            buttonSaveClient.Location = new Point(404, 283);
            buttonSaveClient.Name = "buttonSaveClient";
            buttonSaveClient.Size = new Size(149, 62);
            buttonSaveClient.TabIndex = 14;
            buttonSaveClient.Text = "Guardar Producto";
            buttonSaveClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSaveClient.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.cleaner;
            button1.Location = new Point(570, 283);
            button1.Name = "button1";
            button1.Size = new Size(111, 62);
            button1.TabIndex = 15;
            button1.Text = "Limpiar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // FormNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonSaveClient);
            Controls.Add(textBox5);
            Controls.Add(labelStock);
            Controls.Add(textBox4);
            Controls.Add(labelPrecioVenta);
            Controls.Add(textBox3);
            Controls.Add(labelPrecioCompra);
            Controls.Add(textBox2);
            Controls.Add(labelNombre);
            Controls.Add(textBox1);
            Controls.Add(labelProveedor);
            Controls.Add(labelIngresoProductos);
            Name = "FormNuevoProducto";
            Text = "NUEVO PRODUCTO";
            Load += FormNuevoProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelIngresoProductos;
        private Label labelProveedor;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelNombre;
        private TextBox textBox3;
        private Label labelPrecioCompra;
        private TextBox textBox4;
        private Label labelPrecioVenta;
        private TextBox textBox5;
        private Label labelStock;
        private Button buttonSaveClient;
        private Button button1;
    }
}