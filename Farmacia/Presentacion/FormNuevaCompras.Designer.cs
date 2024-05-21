namespace VistasFarmacia.Forms
{
    partial class FormNuevaCompras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvProductos = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            labelTablaIngresoCompras = new Label();
            labelAcumulado = new Label();
            panel1 = new Panel();
            label3 = new Label();
            lblTotal = new Label();
            btnGuardar = new Button();
            labelCodigo = new Label();
            btnLimpiar = new Button();
            cmbProveedores = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToOrderColumns = true;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Cantidad, Nombre, Marca, PrecioCompra, PrecioVenta, Subtotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(49, 49, 68);
            dgvProductos.Location = new Point(63, 209);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 20;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1028, 497);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellEndEdit += dgvProductos_CellEndEdit;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "Codigo";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // labelTablaIngresoCompras
            // 
            labelTablaIngresoCompras.AutoSize = true;
            labelTablaIngresoCompras.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaIngresoCompras.Location = new Point(63, 27);
            labelTablaIngresoCompras.Name = "labelTablaIngresoCompras";
            labelTablaIngresoCompras.Size = new Size(227, 41);
            labelTablaIngresoCompras.TabIndex = 1;
            labelTablaIngresoCompras.Text = "Nueva Compra";
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
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(labelAcumulado);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(866, 85);
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
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Farmacia.Properties.Resources.ADD;
            btnGuardar.Location = new Point(910, 725);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(182, 85);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Ingresar Compra";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCodigo.Location = new Point(63, 116);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(133, 32);
            labelCodigo.TabIndex = 16;
            labelCodigo.Text = "Proveedor";
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Farmacia.Properties.Resources.cleaner;
            btnLimpiar.Location = new Point(63, 725);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(182, 85);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar Compra";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbProveedores
            // 
            cmbProveedores.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProveedores.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Items.AddRange(new object[] { "" });
            cmbProveedores.Location = new Point(202, 116);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(343, 28);
            cmbProveedores.TabIndex = 26;
            // 
            // FormNuevaCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1154, 835);
            Controls.Add(cmbProveedores);
            Controls.Add(btnLimpiar);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(labelCodigo);
            Controls.Add(labelTablaIngresoCompras);
            Controls.Add(dgvProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNuevaCompras";
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
        private Label labelTablaIngresoCompras;
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
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Subtotal;
    }
}