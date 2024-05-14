

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
            dgvProductos = new DataGridView();
            labelTablaInventario = new Label();
            btnCrear = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            labelAcumulado = new Label();
            label2 = new Label();
            btnReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(49, 49, 68);
            dgvProductos.Location = new Point(64, 152);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.RowHeadersWidth = 15;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(49, 49, 68);
            dgvProductos.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1174, 548);
            dgvProductos.TabIndex = 0;
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
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Image = Farmacia.Properties.Resources.addproduct;
            btnCrear.Location = new Point(834, 727);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(120, 83);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Agregar Producto";
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnAdd_Click;
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
            btnEditar.Click += btnEditar_Click;
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
            btnEliminar.Click += btnEliminar_Click;
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
            label3.Location = new Point(0, 34);
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
            labelAcumulado.Size = new Size(122, 20);
            labelAcumulado.TabIndex = 0;
            labelAcumulado.Text = "TOTAL COMPRA";
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
            // btnReporte
            // 
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Image = Farmacia.Properties.Resources.reportes;
            btnReporte.Location = new Point(63, 727);
            btnReporte.Margin = new Padding(3, 4, 3, 4);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(134, 83);
            btnReporte.TabIndex = 10;
            btnReporte.Text = "Reporte";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1335, 855);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label label2;
        private Label labelAcumulado;
        private Panel panel2;
        private Button btnReporte;
    }
}