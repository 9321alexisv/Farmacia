namespace VistasFarmacia.Forms
{
    partial class FormVentas
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
            labelTablaVentas = new Label();
            btnReporte = new Button();
            panel1 = new Panel();
            labelAcumulado = new Label();
            label3 = new Label();
            lblVentas = new Label();
            dgvVentas = new DataGridView();
            IdVenta = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            lblGanancias = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            btnFiltrar = new Button();
            btnTodos = new Button();
            btnEliminar = new Button();
            btnPdf = new Button();
            btnPDFReporte = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelTablaVentas
            // 
            labelTablaVentas.AutoSize = true;
            labelTablaVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaVentas.Location = new Point(82, 56);
            labelTablaVentas.Margin = new Padding(4, 0, 4, 0);
            labelTablaVentas.Name = "labelTablaVentas";
            labelTablaVentas.Size = new Size(283, 41);
            labelTablaVentas.TabIndex = 1;
            labelTablaVentas.Text = "Historial de Ventas";
            // 
            // btnReporte
            // 
            btnReporte.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReporte.BackColor = Color.Silver;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Image = Farmacia.Properties.Resources.reportes;
            btnReporte.Location = new Point(360, 779);
            btnReporte.Margin = new Padding(4, 6, 4, 6);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(200, 75);
            btnReporte.TabIndex = 4;
            btnReporte.Text = "Reporte Excel";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(labelAcumulado);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblVentas);
            panel1.Location = new Point(1149, 302);
            panel1.Margin = new Padding(4, 6, 4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 5;
            // 
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(0, 0);
            labelAcumulado.Margin = new Padding(4, 0, 4, 0);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(115, 20);
            labelAcumulado.TabIndex = 0;
            labelAcumulado.Text = "TOTAL VENTAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(0, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 41);
            label3.TabIndex = 2;
            label3.Text = "Q";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblVentas.ForeColor = Color.LightGreen;
            lblVentas.Location = new Point(49, 38);
            lblVentas.Margin = new Padding(4, 0, 4, 0);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(77, 41);
            lblVentas.TabIndex = 1;
            lblVentas.Text = "00.0";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVentas.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { IdVenta, Codigo, Producto, Cantidad, PrecioCompra, PrecioVenta, Subtotal });
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.FromArgb(49, 49, 68);
            dgvVentas.Location = new Point(82, 131);
            dgvVentas.Margin = new Padding(4, 6, 4, 6);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 15;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvVentas.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(49, 49, 68);
            dgvVentas.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvVentas.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgvVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1027, 616);
            dgvVentas.TabIndex = 7;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "IdVenta";
            IdVenta.MinimumWidth = 6;
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
            IdVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdVenta.Visible = false;
            IdVenta.Width = 125;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "ID";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.SortMode = DataGridViewColumnSortMode.NotSortable;
            Codigo.Width = 35;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.SortMode = DataGridViewColumnSortMode.NotSortable;
            Producto.Width = 97;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cantidad.Width = 95;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            PrecioCompra.Width = 145;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            PrecioVenta.Width = 124;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            Subtotal.Width = 91;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(49, 49, 68);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblGanancias);
            panel2.Location = new Point(1149, 131);
            panel2.Margin = new Padding(4, 6, 4, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "TOTAL GANANCIAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(0, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 41);
            label2.TabIndex = 2;
            label2.Text = "Q";
            // 
            // lblGanancias
            // 
            lblGanancias.AutoSize = true;
            lblGanancias.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblGanancias.ForeColor = Color.LightGreen;
            lblGanancias.Location = new Point(49, 46);
            lblGanancias.Margin = new Padding(4, 0, 4, 0);
            lblGanancias.Name = "lblGanancias";
            lblGanancias.Size = new Size(77, 41);
            lblGanancias.TabIndex = 1;
            lblGanancias.Text = "00.0";
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(389, 61);
            dtpDesde.Margin = new Padding(4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(171, 34);
            dtpDesde.TabIndex = 8;
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(608, 61);
            dtpHasta.Margin = new Padding(4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(166, 34);
            dtpHasta.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(442, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 10;
            label4.Text = "Desde";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(652, 17);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 11;
            label5.Text = "Hasta";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFiltrar
            // 
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Location = new Point(830, 61);
            btnFiltrar.Margin = new Padding(4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(129, 41);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnTodos
            // 
            btnTodos.FlatStyle = FlatStyle.Flat;
            btnTodos.Location = new Point(980, 61);
            btnTodos.Margin = new Padding(4);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(129, 41);
            btnTodos.TabIndex = 14;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Farmacia.Properties.Resources.borrar;
            btnEliminar.Location = new Point(82, 779);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 75);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPdf.BackColor = Color.LimeGreen;
            btnPdf.FlatAppearance.BorderSize = 0;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Image = Farmacia.Properties.Resources.reportes;
            btnPdf.Location = new Point(909, 781);
            btnPdf.Margin = new Padding(4, 6, 4, 6);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(200, 75);
            btnPdf.TabIndex = 16;
            btnPdf.Text = "Una Venta PDF";
            btnPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnPDFReporte
            // 
            btnPDFReporte.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPDFReporte.BackColor = Color.SteelBlue;
            btnPDFReporte.FlatAppearance.BorderSize = 0;
            btnPDFReporte.FlatStyle = FlatStyle.Flat;
            btnPDFReporte.Image = Farmacia.Properties.Resources.reportes;
            btnPDFReporte.Location = new Point(632, 781);
            btnPDFReporte.Margin = new Padding(4, 6, 4, 6);
            btnPDFReporte.Name = "btnPDFReporte";
            btnPDFReporte.Size = new Size(200, 75);
            btnPDFReporte.TabIndex = 17;
            btnPDFReporte.Text = "Reporte PDF";
            btnPDFReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDFReporte.UseVisualStyleBackColor = false;
            btnPDFReporte.Click += btnPDFReporte_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1401, 869);
            Controls.Add(btnPDFReporte);
            Controls.Add(btnPdf);
            Controls.Add(btnEliminar);
            Controls.Add(btnTodos);
            Controls.Add(btnFiltrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(panel2);
            Controls.Add(dgvVentas);
            Controls.Add(panel1);
            Controls.Add(btnReporte);
            Controls.Add(labelTablaVentas);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "FormVentas";
            Text = "Historial Ventas";
            Load += FormVentas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTablaVentas;
        private Button btnReporte;
        private Panel panel1;
        private Label labelAcumulado;
        private Label lblVentas;
        private Label label3;
        private DataGridView dgvVentas;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label lblGanancias;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label label4;
        private Label label5;
        private Button btnFiltrar;
        private Button btnTodos;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btnPdf;
        private Button btnPDFReporte;
    }
}