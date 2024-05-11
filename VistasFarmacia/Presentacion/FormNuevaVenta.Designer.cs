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
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            toootal = new DataGridViewTextBoxColumn();
            unitaria = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            labelTablaIngresoVentas = new Label();
            btnLimpiarIngresoVentas = new Button();
            btnGuardarIngresoVentas = new Button();
            labelCodigo = new Label();
            labelCantidad = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            labelAcumulado = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(49, 49, 68);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 20;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, cantidad, Descripcion, precio, toootal, unitaria, total, fecha });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(49, 49, 68);
            dataGridView1.Location = new Point(96, 176);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.Size = new Size(1088, 520);
            dataGridView1.TabIndex = 0;
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
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 250;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // toootal
            // 
            toootal.HeaderText = "Total";
            toootal.MinimumWidth = 6;
            toootal.Name = "toootal";
            toootal.Width = 125;
            // 
            // unitaria
            // 
            unitaria.HeaderText = "Ganancia Unitaria";
            unitaria.MinimumWidth = 6;
            unitaria.Name = "unitaria";
            unitaria.Width = 120;
            // 
            // total
            // 
            total.HeaderText = "Ganancia Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 125;
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
            // btnLimpiarIngresoVentas
            // 
            btnLimpiarIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnLimpiarIngresoVentas.Image = Farmacia.Properties.Resources.cleaner;
            btnLimpiarIngresoVentas.Location = new Point(1014, 719);
            btnLimpiarIngresoVentas.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarIngresoVentas.Name = "btnLimpiarIngresoVentas";
            btnLimpiarIngresoVentas.Size = new Size(170, 85);
            btnLimpiarIngresoVentas.TabIndex = 2;
            btnLimpiarIngresoVentas.Text = "Limpiar Ventas";
            btnLimpiarIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarIngresoVentas.UseVisualStyleBackColor = true;
            btnLimpiarIngresoVentas.Click += btnLimpiarIngresoVentas_Click;
            // 
            // btnGuardarIngresoVentas
            // 
            btnGuardarIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnGuardarIngresoVentas.Image = Farmacia.Properties.Resources.save;
            btnGuardarIngresoVentas.Location = new Point(837, 719);
            btnGuardarIngresoVentas.Margin = new Padding(3, 4, 3, 4);
            btnGuardarIngresoVentas.Name = "btnGuardarIngresoVentas";
            btnGuardarIngresoVentas.Size = new Size(170, 85);
            btnGuardarIngresoVentas.TabIndex = 3;
            btnGuardarIngresoVentas.Text = "Guardar Ventas";
            btnGuardarIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarIngresoVentas.UseVisualStyleBackColor = true;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCodigo.Location = new Point(90, 107);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(103, 32);
            labelCodigo.TabIndex = 5;
            labelCodigo.Text = "Código:";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCantidad.Location = new Point(278, 107);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(123, 32);
            labelCantidad.TabIndex = 6;
            labelCantidad.Text = "Cantidad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 113);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 109);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 27);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Farmacia.Properties.Resources.ADD;
            button1.Location = new Point(481, 99);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 69);
            button1.TabIndex = 9;
            button1.Text = "Ingresar Venta";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Farmacia.Properties.Resources.edit;
            button2.Location = new Point(635, 99);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(150, 69);
            button2.TabIndex = 10;
            button2.Text = "Editar Venta";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Farmacia.Properties.Resources.borrar;
            button3.Location = new Point(790, 99);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(147, 69);
            button3.TabIndex = 11;
            button3.Text = "Borrar Venta";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
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
            labelAcumulado.Location = new Point(48, 8);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(110, 20);
            labelAcumulado.TabIndex = 13;
            labelAcumulado.Text = "ACUMULADO:";
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
            // FormNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1264, 844);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelCantidad);
            Controls.Add(labelCodigo);
            Controls.Add(btnGuardarIngresoVentas);
            Controls.Add(btnLimpiarIngresoVentas);
            Controls.Add(labelTablaIngresoVentas);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNuevaVenta";
            Text = "Nueva Venta";
            Load += FormIngresoVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn acumulado;
        private Label labelTablaIngresoVentas;
        private Button btnLimpiarIngresoVentas;
        private Button btnGuardarIngresoVentas;
        private Label labelCodigo;
        private Label labelCantidad;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label3;
        private Label labelAcumulado;
        private Label label2;
        private Panel panel2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn toootal;
        private DataGridViewTextBoxColumn unitaria;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn fecha;
    }
}