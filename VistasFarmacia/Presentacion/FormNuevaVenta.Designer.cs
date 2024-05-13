namespace VistasFarmacia.Forms
{
    partial class FormNuevaVenta
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
            dgvNuevaVenta = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            labelTablaIngresoVentas = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            lblCliente = new Label();
            panel1 = new Panel();
            label3 = new Label();
            lblTotal = new Label();
            labelAcumulado = new Label();
            panel2 = new Panel();
            cmbClientes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvNuevaVenta).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNuevaVenta
            // 
            dgvNuevaVenta.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvNuevaVenta.BorderStyle = BorderStyle.None;
            dgvNuevaVenta.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNuevaVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNuevaVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNuevaVenta.ColumnHeadersHeight = 20;
            dgvNuevaVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNuevaVenta.Columns.AddRange(new DataGridViewColumn[] { Codigo, cantidad, Producto, precio, PrecioCompra, Subtotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNuevaVenta.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNuevaVenta.EnableHeadersVisualStyles = false;
            dgvNuevaVenta.GridColor = Color.FromArgb(49, 49, 68);
            dgvNuevaVenta.Location = new Point(96, 176);
            dgvNuevaVenta.Margin = new Padding(3, 4, 3, 4);
            dgvNuevaVenta.Name = "dgvNuevaVenta";
            dgvNuevaVenta.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvNuevaVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvNuevaVenta.RowHeadersWidth = 25;
            dgvNuevaVenta.Size = new Size(1088, 520);
            dgvNuevaVenta.TabIndex = 0;
            dgvNuevaVenta.CellEndEdit += dgvNuevaVenta_CellEndEdit;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 65;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 90;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 250;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // labelTablaIngresoVentas
            // 
            labelTablaIngresoVentas.AutoSize = true;
            labelTablaIngresoVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaIngresoVentas.Location = new Point(91, 17);
            labelTablaIngresoVentas.Name = "labelTablaIngresoVentas";
            labelTablaIngresoVentas.Size = new Size(196, 41);
            labelTablaIngresoVentas.TabIndex = 1;
            labelTablaIngresoVentas.Text = "Nueva Venta";
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Farmacia.Properties.Resources.cleaner;
            btnLimpiar.Location = new Point(1014, 719);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 85);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar Venta";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Farmacia.Properties.Resources.save;
            btnGuardar.Location = new Point(837, 719);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 85);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar Venta";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCliente.Location = new Point(96, 108);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(93, 32);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(994, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 96);
            panel1.TabIndex = 14;
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
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblTotal.ForeColor = Color.LightGreen;
            lblTotal.Location = new Point(54, 40);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(136, 41);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "1,000.00";
            // 
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(48, 8);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(54, 20);
            labelAcumulado.TabIndex = 13;
            labelAcumulado.Text = "TOTAL";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelAcumulado);
            panel2.Location = new Point(993, 17);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 35);
            panel2.TabIndex = 15;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(211, 114);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(290, 28);
            cmbClientes.TabIndex = 16;
            // 
            // FormNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1264, 844);
            Controls.Add(cmbClientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblCliente);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(labelTablaIngresoVentas);
            Controls.Add(dgvNuevaVenta);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNuevaVenta";
            Text = "Nueva Venta";
            Load += FormIngresoVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNuevaVenta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNuevaVenta;
        private DataGridViewTextBoxColumn acumulado;
        private Label labelTablaIngresoVentas;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label lblCliente;
        private Panel panel1;
        private Label label3;
        private Label labelAcumulado;
        private Label lblTotal;
        private Panel panel2;
        private ComboBox cmbClientes;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Subtotal;
    }
}