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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelTablaVentas = new Label();
            btnReporte = new Button();
            panel1 = new Panel();
            labelAcumulado = new Label();
            label3 = new Label();
            lblVentas = new Label();
            dgvVentas = new DataGridView();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelTablaVentas
            // 
            labelTablaVentas.AutoSize = true;
            labelTablaVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaVentas.Location = new Point(152, 48);
            labelTablaVentas.Name = "labelTablaVentas";
            labelTablaVentas.Size = new Size(283, 41);
            labelTablaVentas.TabIndex = 1;
            labelTablaVentas.Text = "Historial de Ventas";
            // 
            // btnReporte
            // 
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Image = Farmacia.Properties.Resources.reportes;
            btnReporte.Location = new Point(990, 681);
            btnReporte.Margin = new Padding(3, 4, 3, 4);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(212, 89);
            btnReporte.TabIndex = 4;
            btnReporte.Text = "Generar Excel";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(labelAcumulado);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblVentas);
            panel1.Location = new Point(706, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 96);
            panel1.TabIndex = 5;
            // 
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(0, 0);
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
            label3.Location = new Point(0, 42);
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
            lblVentas.Location = new Point(51, 42);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(136, 41);
            lblVentas.TabIndex = 1;
            lblVentas.Text = "1,000.00";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Cantidad, PrecioCompra, PrecioVenta, Subtotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.FromArgb(49, 49, 68);
            dgvVentas.Location = new Point(152, 140);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 15;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(49, 49, 68);
            dgvVentas.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvVentas.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgvVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1050, 525);
            dgvVentas.TabIndex = 7;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Cod. Producto";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 49, 68);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblGanancias);
            panel2.Location = new Point(920, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 96);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
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
            label2.Location = new Point(0, 42);
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
            lblGanancias.Location = new Point(51, 42);
            lblGanancias.Name = "lblGanancias";
            lblGanancias.Size = new Size(136, 41);
            lblGanancias.TabIndex = 1;
            lblGanancias.Text = "1,000.00";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1298, 783);
            Controls.Add(panel2);
            Controls.Add(dgvVentas);
            Controls.Add(panel1);
            Controls.Add(btnReporte);
            Controls.Add(labelTablaVentas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Subtotal;
    }
}