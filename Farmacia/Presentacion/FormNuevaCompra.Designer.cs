namespace VistasFarmacia.Forms
{
    partial class FormNuevaCompra
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvProductos = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            StockActual = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            labelAcumulado = new Label();
            panel1 = new Panel();
            label3 = new Label();
            lblTotal = new Label();
            btnGuardar = new Button();
            labelCodigo = new Label();
            btnLimpiar = new Button();
            cmbProveedores = new ComboBox();
            checkPromedio = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToOrderColumns = true;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Nombre, Cantidad, Marca, StockActual, PrecioCompra, PrecioVenta, Subtotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LimeGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(49, 49, 68);
            dgvProductos.Location = new Point(63, 138);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 20;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1276, 568);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellEndEdit += dgvProductos_CellEndEdit;
            dgvProductos.EditingControlShowing += dgvProductos_EditingControlShowing;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "Codigo";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            IdProducto.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 123;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 98;
            // 
            // StockActual
            // 
            StockActual.HeaderText = "Stock Actual";
            StockActual.MinimumWidth = 6;
            StockActual.Name = "StockActual";
            StockActual.ReadOnly = true;
            StockActual.Width = 158;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 177;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Width = 158;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 119;
            // 
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(3, 0);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(72, 28);
            labelAcumulado.TabIndex = 13;
            labelAcumulado.Text = "TOTAL";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(labelAcumulado);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(1114, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 96);
            panel1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(-1, 53);
            label3.Name = "label3";
            label3.Size = new Size(41, 41);
            label3.TabIndex = 2;
            label3.Text = "Q";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblTotal.ForeColor = Color.LightGreen;
            lblTotal.Location = new Point(60, 53);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(77, 41);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "00.0";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Image = Farmacia.Properties.Resources._new;
            btnGuardar.Location = new Point(1189, 735);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 65);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCodigo.Location = new Point(63, 47);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(163, 41);
            labelCodigo.TabIndex = 16;
            labelCodigo.Text = "Proveedor";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Image = Farmacia.Properties.Resources.clear;
            btnLimpiar.Location = new Point(63, 735);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 65);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Cancelar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbProveedores
            // 
            cmbProveedores.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProveedores.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Items.AddRange(new object[] { "" });
            cmbProveedores.Location = new Point(241, 47);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(343, 36);
            cmbProveedores.TabIndex = 26;
            // 
            // checkPromedio
            // 
            checkPromedio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkPromedio.AutoSize = true;
            checkPromedio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkPromedio.ForeColor = Color.White;
            checkPromedio.Location = new Point(780, 752);
            checkPromedio.Name = "checkPromedio";
            checkPromedio.Size = new Size(262, 32);
            checkPromedio.TabIndex = 27;
            checkPromedio.Text = "Utilizar precios promedio";
            checkPromedio.UseVisualStyleBackColor = true;
            // 
            // FormNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1369, 835);
            Controls.Add(checkPromedio);
            Controls.Add(cmbProveedores);
            Controls.Add(btnLimpiar);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(labelCodigo);
            Controls.Add(dgvProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNuevaCompra";
            Text = "Nueva Compra";
            Load += FormIngresoCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Panel panel2;
        private Label labelAcumulado;
        private Panel panel1;
        private Label label3;
        private Label lblTotal;
        private Button button3;
        private Button btnGuardar;
        private Label labelCodigo;
        private Button btnGuardarIngresoVentas;
        private Button btnLimpiar;
        private ComboBox cmbProveedores;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn StockActual;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Subtotal;
        private CheckBox checkPromedio;
    }
}