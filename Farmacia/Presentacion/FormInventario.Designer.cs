

namespace VistasFarmacia.Forms
{
    partial class FormInventario
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            dgvProductos = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            IdMarca = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            StockMinimo = new DataGridViewTextBoxColumn();
            labelTablaInventario = new Label();
            btnCrear = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            lblTotalTitulo = new Label();
            label3 = new Label();
            lblTotal = new Label();
            btnReporte = new Button();
            btnBuscar = new Button();
            txtQuery = new TextBox();
            btnTodo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, IdMarca, Marca, PrecioCompra, PrecioVenta, Stock, StockMinimo });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle14;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(49, 49, 68);
            dgvProductos.Location = new Point(64, 152);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 15;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.SteelBlue;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvProductos.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(49, 49, 68);
            dgvProductos.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1174, 548);
            dgvProductos.TabIndex = 0;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "ID";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Width = 60;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // IdMarca
            // 
            IdMarca.HeaderText = "IdMarca";
            IdMarca.MinimumWidth = 6;
            IdMarca.Name = "IdMarca";
            IdMarca.ReadOnly = true;
            IdMarca.Visible = false;
            IdMarca.Width = 125;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 98;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PrecioCompra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 171;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 152;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 91;
            // 
            // StockMinimo
            // 
            StockMinimo.HeaderText = "StockMinimo";
            StockMinimo.MinimumWidth = 6;
            StockMinimo.Name = "StockMinimo";
            StockMinimo.ReadOnly = true;
            StockMinimo.Visible = false;
            StockMinimo.Width = 125;
            // 
            // labelTablaInventario
            // 
            labelTablaInventario.AutoSize = true;
            labelTablaInventario.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaInventario.Location = new Point(64, 65);
            labelTablaInventario.Name = "labelTablaInventario";
            labelTablaInventario.Size = new Size(160, 41);
            labelTablaInventario.TabIndex = 1;
            labelTablaInventario.Text = "Productos";
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCrear.BackColor = Color.LimeGreen;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 12F);
            btnCrear.Image = Farmacia.Properties.Resources._new;
            btnCrear.Location = new Point(1088, 746);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(150, 65);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Nuevo";
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Farmacia.Properties.Resources.edit;
            btnEditar.Location = new Point(862, 746);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 65);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Farmacia.Properties.Resources.delete;
            btnEliminar.Location = new Point(64, 746);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 65);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(lblTotalTitulo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(1001, 25);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 96);
            panel1.TabIndex = 7;
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.Dock = DockStyle.Top;
            lblTotalTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTitulo.ForeColor = Color.White;
            lblTotalTitulo.Location = new Point(0, 0);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(237, 28);
            lblTotalTitulo.TabIndex = 0;
            lblTotalTitulo.Text = "TOTAL INVENTARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(0, 41);
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
            lblTotal.Location = new Point(66, 38);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(77, 41);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0.00";
            // 
            // btnReporte
            // 
            btnReporte.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReporte.BackColor = Color.Silver;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Segoe UI", 12F);
            btnReporte.Image = Farmacia.Properties.Resources.excel;
            btnReporte.Location = new Point(652, 746);
            btnReporte.Margin = new Padding(3, 4, 3, 4);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(150, 65);
            btnReporte.TabIndex = 10;
            btnReporte.Text = "Excel";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(613, 63);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 40);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtQuery
            // 
            txtQuery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuery.Location = new Point(283, 68);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(290, 34);
            txtQuery.TabIndex = 13;
            txtQuery.TextChanged += txtQuery_TextChanged;
            // 
            // btnTodo
            // 
            btnTodo.FlatStyle = FlatStyle.Flat;
            btnTodo.Font = new Font("Segoe UI", 12F);
            btnTodo.Location = new Point(797, 65);
            btnTodo.Margin = new Padding(3, 4, 3, 4);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new Size(150, 40);
            btnTodo.TabIndex = 14;
            btnTodo.Text = "Ver todos";
            btnTodo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1305, 855);
            Controls.Add(btnTodo);
            Controls.Add(txtQuery);
            Controls.Add(btnBuscar);
            Controls.Add(btnReporte);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(labelTablaInventario);
            Controls.Add(dgvProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInventario";
            Text = "Inventario";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label labelTablaInventario;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnEliminar;
        private Panel panel1;
        private Label label3;
        private Label lblTotal;
        private Button btnReporte;
        private Button btnBuscar;
        private TextBox txtQuery;
        private Button btnTodo;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn StockMinimo;
        private Label lblTotalTitulo;
    }
}