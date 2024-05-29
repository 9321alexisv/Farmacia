namespace VistasFarmacia.Forms
{
    partial class FormCompras
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
            dgvCompras = new DataGridView();
            labelTablaCompras = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            labelAcumulado = new Label();
            lblCompras = new Label();
            btnReporte = new Button();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnFiltrar = new Button();
            btnTodo = new Button();
            btnEliminar = new Button();
            btnPDFCompra = new Button();
            btnPDFReporte = new Button();
            IdCompra = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvCompras.BorderStyle = BorderStyle.None;
            dgvCompras.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { IdCompra, IdProducto, Marca, Producto, Cantidad, Precio, Subtotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCompras.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.Location = new Point(77, 121);
            dgvCompras.Margin = new Padding(3, 4, 3, 4);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.RowHeadersWidth = 20;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(1019, 553);
            dgvCompras.TabIndex = 0;
            // 
            // labelTablaCompras
            // 
            labelTablaCompras.AutoSize = true;
            labelTablaCompras.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaCompras.Location = new Point(77, 39);
            labelTablaCompras.Name = "labelTablaCompras";
            labelTablaCompras.Size = new Size(314, 41);
            labelTablaCompras.TabIndex = 1;
            labelTablaCompras.Text = "Historial de Compras";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblCompras);
            panel1.Location = new Point(1153, 132);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 96);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(-1, 35);
            label3.Name = "label3";
            label3.Size = new Size(41, 41);
            label3.TabIndex = 2;
            label3.Text = "Q";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelAcumulado);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 35);
            panel2.TabIndex = 17;
            // 
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(0, 0);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(106, 20);
            labelAcumulado.TabIndex = 13;
            labelAcumulado.Text = "ACUMULADO";
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblCompras.ForeColor = Color.LightGreen;
            lblCompras.Location = new Point(71, 39);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(77, 41);
            lblCompras.TabIndex = 1;
            lblCompras.Text = "0.00";
            // 
            // btnReporte
            // 
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Image = Farmacia.Properties.Resources.reportes;
            btnReporte.Location = new Point(397, 715);
            btnReporte.Margin = new Padding(3, 4, 3, 4);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(200, 75);
            btnReporte.TabIndex = 17;
            btnReporte.Text = "Reporte Excel";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarFont = new Font("Segoe UI", 13.8F);
            dtpInicio.Font = new Font("Segoe UI", 12F);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(397, 53);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(150, 34);
            dtpInicio.TabIndex = 18;
            // 
            // dtpFin
            // 
            dtpFin.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFin.Font = new Font("Segoe UI", 12F);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(564, 53);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(150, 34);
            dtpFin.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(436, 22);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 20;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(605, 22);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 21;
            label2.Text = "Hasta";
            // 
            // btnFiltrar
            // 
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Location = new Point(774, 43);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(137, 47);
            btnFiltrar.TabIndex = 22;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnTodo
            // 
            btnTodo.FlatStyle = FlatStyle.Flat;
            btnTodo.Location = new Point(959, 43);
            btnTodo.Margin = new Padding(3, 4, 3, 4);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new Size(137, 47);
            btnTodo.TabIndex = 23;
            btnTodo.Text = "Todo";
            btnTodo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = Farmacia.Properties.Resources.reportes;
            btnEliminar.Location = new Point(77, 715);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(200, 75);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnPDFCompra
            // 
            btnPDFCompra.FlatStyle = FlatStyle.Flat;
            btnPDFCompra.Image = Farmacia.Properties.Resources.reportes;
            btnPDFCompra.Location = new Point(896, 715);
            btnPDFCompra.Margin = new Padding(3, 4, 3, 4);
            btnPDFCompra.Name = "btnPDFCompra";
            btnPDFCompra.Size = new Size(200, 75);
            btnPDFCompra.TabIndex = 25;
            btnPDFCompra.Text = "PDF Compra";
            btnPDFCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDFCompra.UseVisualStyleBackColor = true;
            btnPDFCompra.Click += btnPDFCompra_Click;
            // 
            // btnPDFReporte
            // 
            btnPDFReporte.FlatStyle = FlatStyle.Flat;
            btnPDFReporte.Image = Farmacia.Properties.Resources.reportes;
            btnPDFReporte.Location = new Point(642, 715);
            btnPDFReporte.Margin = new Padding(3, 4, 3, 4);
            btnPDFReporte.Name = "btnPDFReporte";
            btnPDFReporte.Size = new Size(200, 75);
            btnPDFReporte.TabIndex = 26;
            btnPDFReporte.Text = "Reporte PDF";
            btnPDFReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDFReporte.UseVisualStyleBackColor = true;
            btnPDFReporte.Click += btnPDFReporte_Click;
            // 
            // IdCompra
            // 
            IdCompra.HeaderText = "IdCompra";
            IdCompra.MinimumWidth = 6;
            IdCompra.Name = "IdCompra";
            IdCompra.ReadOnly = true;
            IdCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdCompra.Visible = false;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "ID";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1397, 833);
            Controls.Add(btnPDFReporte);
            Controls.Add(btnPDFCompra);
            Controls.Add(btnEliminar);
            Controls.Add(btnTodo);
            Controls.Add(btnFiltrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
            Controls.Add(btnReporte);
            Controls.Add(panel1);
            Controls.Add(labelTablaCompras);
            Controls.Add(dgvCompras);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCompras";
            Text = "Historial Compras";
            TransparencyKey = Color.Transparent;
            Load += FormCompras_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCompras;
        private Label labelTablaCompras;
        private Panel panel1;
        private Label label3;
        private Label lblCompras;
        private Label labelAcumulado;
        private Panel panel2;
        private Button btnReporte;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Label label1;
        private Label label2;
        private Button btnFiltrar;
        private Button btnTodo;
        private Button btnEliminar;
        private Button btnPDFCompra;
        private Button btnPDFReporte;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
    }
}