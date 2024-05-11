

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            precioC = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            ganancia = new DataGridViewTextBoxColumn();
            totalCompra = new DataGridViewTextBoxColumn();
            totalVenta = new DataGridViewTextBoxColumn();
            labelTablaInventario = new Label();
            btnAdd = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            labelAcumulado = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(49, 49, 68);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, precio, cant, precioC, stock, ganancia, totalCompra, totalVenta });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(49, 49, 68);
            dataGridView1.Location = new Point(64, 152);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersWidth = 15;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(49, 49, 68);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView1.Size = new Size(1174, 548);
            dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 60;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 250;
            // 
            // precio
            // 
            precio.HeaderText = "Precio Venta";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // cant
            // 
            cant.HeaderText = "Cantidad Comprada";
            cant.MinimumWidth = 6;
            cant.Name = "cant";
            cant.Width = 125;
            // 
            // precioC
            // 
            precioC.HeaderText = "Precio Uni. Comp.";
            precioC.MinimumWidth = 6;
            precioC.Name = "precioC";
            precioC.Width = 125;
            // 
            // stock
            // 
            stock.HeaderText = "Existencia";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.Width = 125;
            // 
            // ganancia
            // 
            ganancia.HeaderText = "Ganancia";
            ganancia.MinimumWidth = 6;
            ganancia.Name = "ganancia";
            ganancia.Width = 125;
            // 
            // totalCompra
            // 
            totalCompra.HeaderText = "Precio Total Compra";
            totalCompra.MinimumWidth = 6;
            totalCompra.Name = "totalCompra";
            totalCompra.Width = 125;
            // 
            // totalVenta
            // 
            totalVenta.HeaderText = "Precio Total Venta";
            totalVenta.MinimumWidth = 6;
            totalVenta.Name = "totalVenta";
            totalVenta.Width = 125;
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
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = Farmacia.Properties.Resources.addproduct;
            btnAdd.Location = new Point(834, 727);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 83);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar Producto";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = Farmacia.Properties.Resources.edit;
            btnEditar.Location = new Point(979, 727);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 83);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar Producto";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = Farmacia.Properties.Resources.borrar;
            btnEliminar.Location = new Point(1117, 727);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 83);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1051, 31);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 96);
            panel1.TabIndex = 7;
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
            panel2.Size = new Size(191, 31);
            panel2.TabIndex = 8;
            // 
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(49, 5);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(111, 20);
            labelAcumulado.TabIndex = 0;
            labelAcumulado.Text = "TOTAL VENTA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(65, 39);
            label2.Name = "label2";
            label2.Size = new Size(136, 41);
            label2.TabIndex = 1;
            label2.Text = "1,000.00";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(49, 49, 68);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(834, 31);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 96);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 31);
            panel4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 5);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 0;
            label5.Text = "TOTAL COMPRA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(-1, 35);
            label1.Name = "label1";
            label1.Size = new Size(41, 41);
            label1.TabIndex = 2;
            label1.Text = "Q";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.LightGreen;
            label4.Location = new Point(65, 39);
            label4.Name = "label4";
            label4.Size = new Size(136, 41);
            label4.TabIndex = 1;
            label4.Text = "1,000.00";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Farmacia.Properties.Resources.reportes;
            button1.Location = new Point(63, 727);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(134, 83);
            button1.TabIndex = 10;
            button1.Text = "Reportes";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1335, 855);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(labelTablaInventario);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInventario";
            Text = "Inventario";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelTablaInventario;
        private Button btnAdd;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn precioC;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn ganancia;
        private DataGridViewTextBoxColumn totalCompra;
        private DataGridViewTextBoxColumn totalVenta;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label labelAcumulado;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Label label1;
        private Label label4;
        private Button button1;
    }
}