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
            lblMarca = new Label();
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
            cmbMarca = new ComboBox();
            txtStockMinimo = new TextBox();
            lblStockMinimo = new Label();
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
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(78, 182);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(92, 32);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(327, 260);
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
            labelNombre.Location = new Point(78, 257);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(228, 32);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre Producto:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(327, 334);
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
            labelPrecioCompra.Location = new Point(78, 328);
            labelPrecioCompra.Name = "labelPrecioCompra";
            labelPrecioCompra.Size = new Size(190, 32);
            labelPrecioCompra.TabIndex = 6;
            labelPrecioCompra.Text = "Precio Compra:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(327, 400);
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
            labelPrecioVenta.Location = new Point(78, 400);
            labelPrecioVenta.Name = "labelPrecioVenta";
            labelPrecioVenta.Size = new Size(164, 32);
            labelPrecioVenta.TabIndex = 8;
            labelPrecioVenta.Text = "Precio Venta:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(327, 474);
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
            labelStock.Location = new Point(78, 472);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(83, 32);
            labelStock.TabIndex = 10;
            labelStock.Text = "Stock:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Image = Farmacia.Properties.Resources._new;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(731, 23);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 65);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Image = Farmacia.Properties.Resources.clear;
            btnLimpiar.Location = new Point(533, 23);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 65);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(327, 186);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(286, 28);
            cmbMarca.TabIndex = 16;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(744, 474);
            txtStockMinimo.Margin = new Padding(3, 4, 3, 4);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(114, 27);
            txtStockMinimo.TabIndex = 18;
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStockMinimo.ForeColor = Color.White;
            lblStockMinimo.Location = new Point(495, 472);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(178, 32);
            lblStockMinimo.TabIndex = 17;
            lblStockMinimo.Text = "Stock Mínimo:";
            // 
            // FormNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(914, 600);
            Controls.Add(txtStockMinimo);
            Controls.Add(lblStockMinimo);
            Controls.Add(cmbMarca);
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
            Controls.Add(lblMarca);
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
        private Label lblMarca;
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
        private ComboBox cmbMarca;
        private TextBox txtStockMinimo;
        private Label lblStockMinimo;
    }
}