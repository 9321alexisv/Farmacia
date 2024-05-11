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
            labelTablaVentas = new Label();
            btnLimpiarVentas = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            labelAcumulado = new Label();
            panel2 = new Panel();
            dataGridViewVentas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
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
            // btnLimpiarVentas
            // 
            btnLimpiarVentas.FlatStyle = FlatStyle.Flat;
            btnLimpiarVentas.Image = Farmacia.Properties.Resources.cleaner;
            btnLimpiarVentas.Location = new Point(966, 691);
            btnLimpiarVentas.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarVentas.Name = "btnLimpiarVentas";
            btnLimpiarVentas.Size = new Size(144, 89);
            btnLimpiarVentas.TabIndex = 2;
            btnLimpiarVentas.Text = "Limpiar";
            btnLimpiarVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarVentas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Farmacia.Properties.Resources.reportes;
            button1.Location = new Point(793, 691);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 89);
            button1.TabIndex = 4;
            button1.Text = "Reportes";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(920, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 96);
            panel1.TabIndex = 5;
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
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(49, 5);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(110, 20);
            labelAcumulado.TabIndex = 0;
            labelAcumulado.Text = "ACUMULADO:";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelAcumulado);
            panel2.Location = new Point(919, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 31);
            panel2.TabIndex = 6;
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.AllowUserToOrderColumns = true;
            dataGridViewVentas.BackgroundColor = Color.FromArgb(49, 49, 68);
            dataGridViewVentas.BorderStyle = BorderStyle.None;
            dataGridViewVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column6 });
            dataGridViewVentas.EnableHeadersVisualStyles = false;
            dataGridViewVentas.GridColor = Color.FromArgb(49, 49, 68);
            dataGridViewVentas.Location = new Point(152, 144);
            dataGridViewVentas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewVentas.RowHeadersWidth = 15;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewVentas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVentas.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewVentas.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewVentas.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridViewVentas.Size = new Size(958, 525);
            dataGridViewVentas.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descripción";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 300;
            // 
            // Column5
            // 
            Column5.HeaderText = "Precio";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column6
            // 
            Column6.HeaderText = "Fecha";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 102;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1298, 783);
            Controls.Add(dataGridViewVentas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnLimpiarVentas);
            Controls.Add(labelTablaVentas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVentas";
            Text = "Historial Ventas";
            Load += FormVentas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTablaVentas;
        private Button btnLimpiarVentas;
        private Button button1;
        private Panel panel1;
        private Label labelAcumulado;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private DataGridView dataGridViewVentas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
    }
}