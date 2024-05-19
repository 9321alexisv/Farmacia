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
            lblTitulo = new Label();
            labelProveedor = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            txtPrecioCompra = new TextBox();
            labelPrecioCompra = new Label();
            txtPrecioVenta = new TextBox();
            labelPrecioVenta = new Label();
            txtStock = new TextBox();
            labelStock = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            cmbProveedor = new ComboBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(88, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Nuevo Producto";
            // 
            // labelProveedor
            // 
            labelProveedor.AutoSize = true;
            labelProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelProveedor.ForeColor = Color.White;
            labelProveedor.Location = new Point(88, 109);
            labelProveedor.Name = "labelProveedor";
            labelProveedor.Size = new Size(133, 32);
            labelProveedor.TabIndex = 2;
            labelProveedor.Text = "Proveedor";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(337, 187);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(286, 27);
            txtNombre.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(88, 184);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(228, 32);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre Producto:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(337, 261);
            txtPrecioCompra.Margin = new Padding(3, 4, 3, 4);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(114, 27);
            txtPrecioCompra.TabIndex = 7;
            // 
            // labelPrecioCompra
            // 
            labelPrecioCompra.AutoSize = true;
            labelPrecioCompra.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelPrecioCompra.ForeColor = Color.White;
            labelPrecioCompra.Location = new Point(88, 255);
            labelPrecioCompra.Name = "labelPrecioCompra";
            labelPrecioCompra.Size = new Size(190, 32);
            labelPrecioCompra.TabIndex = 6;
            labelPrecioCompra.Text = "Precio Compra:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(337, 327);
            txtPrecioVenta.Margin = new Padding(3, 4, 3, 4);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(114, 27);
            txtPrecioVenta.TabIndex = 9;
            // 
            // labelPrecioVenta
            // 
            labelPrecioVenta.AutoSize = true;
            labelPrecioVenta.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelPrecioVenta.ForeColor = Color.White;
            labelPrecioVenta.Location = new Point(88, 327);
            labelPrecioVenta.Name = "labelPrecioVenta";
            labelPrecioVenta.Size = new Size(164, 32);
            labelPrecioVenta.TabIndex = 8;
            labelPrecioVenta.Text = "Precio Venta:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(337, 401);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(114, 27);
            txtStock.TabIndex = 11;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(88, 399);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(83, 32);
            labelStock.TabIndex = 10;
            labelStock.Text = "Stock:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Farmacia.Properties.Resources.ADD;
            btnGuardar.Location = new Point(337, 488);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 83);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar Producto";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Farmacia.Properties.Resources.cleaner;
            btnLimpiar.Location = new Point(88, 488);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 83);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(337, 113);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(286, 28);
            cmbProveedor.TabIndex = 16;
            // 
            // FormNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(914, 600);
            Controls.Add(cmbProveedor);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtStock);
            Controls.Add(labelStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(labelPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(labelPrecioCompra);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Controls.Add(labelProveedor);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNuevoProducto";
            Text = "Nuevo Producto";
            Load += FormNuevoProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label labelProveedor;
        private TextBox txtNombre;
        private Label labelNombre;
        private TextBox txtPrecioCompra;
        private Label labelPrecioCompra;
        private TextBox txtPrecioVenta;
        private Label labelPrecioVenta;
        private TextBox txtStock;
        private Label labelStock;
        private Button btnGuardar;
        private Button btnLimpiar;
        private ComboBox cmbProveedor;
    }
}