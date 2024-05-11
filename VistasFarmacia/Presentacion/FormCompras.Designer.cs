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
            dataGridViewCompras = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            acumulado = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            labelTablaCompras = new Label();
            btnLimpiarCompras = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            labelAcumulado = new Label();
            label2 = new Label();
            buttonReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCompras
            // 
            dataGridViewCompras.BackgroundColor = Color.FromArgb(49, 49, 68);
            dataGridViewCompras.BorderStyle = BorderStyle.None;
            dataGridViewCompras.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompras.Columns.AddRange(new DataGridViewColumn[] { Codigo, cantidad, Descripcion, precio, total, acumulado, fecha });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCompras.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCompras.EnableHeadersVisualStyles = false;
            dataGridViewCompras.Location = new Point(118, 135);
            dataGridViewCompras.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.RowHeadersWidth = 20;
            dataGridViewCompras.Size = new Size(1019, 535);
            dataGridViewCompras.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 60;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 60;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 350;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // acumulado
            // 
            acumulado.HeaderText = "Acumulado";
            acumulado.MinimumWidth = 6;
            acumulado.Name = "acumulado";
            acumulado.Width = 125;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 125;
            // 
            // labelTablaCompras
            // 
            labelTablaCompras.AutoSize = true;
            labelTablaCompras.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaCompras.Location = new Point(118, 43);
            labelTablaCompras.Name = "labelTablaCompras";
            labelTablaCompras.Size = new Size(314, 41);
            labelTablaCompras.TabIndex = 1;
            labelTablaCompras.Text = "Historial de Compras";
            // 
            // btnLimpiarCompras
            // 
            btnLimpiarCompras.FlatStyle = FlatStyle.Flat;
            btnLimpiarCompras.Image = Farmacia.Properties.Resources.cleaner;
            btnLimpiarCompras.Location = new Point(978, 696);
            btnLimpiarCompras.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarCompras.Name = "btnLimpiarCompras";
            btnLimpiarCompras.Size = new Size(159, 93);
            btnLimpiarCompras.TabIndex = 2;
            btnLimpiarCompras.Text = "Limpiar";
            btnLimpiarCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarCompras.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(947, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 96);
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
            panel2.Size = new Size(191, 35);
            panel2.TabIndex = 17;
            // 
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(48, 8);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(110, 20);
            labelAcumulado.TabIndex = 13;
            labelAcumulado.Text = "ACUMULADO:";
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
            // buttonReporte
            // 
            buttonReporte.FlatStyle = FlatStyle.Flat;
            buttonReporte.Image = Farmacia.Properties.Resources.reportes;
            buttonReporte.Location = new Point(790, 696);
            buttonReporte.Margin = new Padding(3, 4, 3, 4);
            buttonReporte.Name = "buttonReporte";
            buttonReporte.Size = new Size(159, 93);
            buttonReporte.TabIndex = 17;
            buttonReporte.Text = "Reportes";
            buttonReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReporte.UseVisualStyleBackColor = true;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1271, 833);
            Controls.Add(buttonReporte);
            Controls.Add(panel1);
            Controls.Add(btnLimpiarCompras);
            Controls.Add(labelTablaCompras);
            Controls.Add(dataGridViewCompras);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCompras";
            Text = "Historial Compras";
            TransparencyKey = Color.Transparent;
            Load += FormCompras_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCompras;
        private Label labelTablaCompras;
        private Button btnLimpiarCompras;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn acumulado;
        private DataGridViewTextBoxColumn fecha;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label labelAcumulado;
        private Panel panel2;
        private Button buttonReporte;
    }
}