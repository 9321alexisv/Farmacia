namespace VistasFarmacia.Forms
{
    partial class FormIngresoCompras
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            labelTablaIngresoCompras = new Label();
            panel2 = new Panel();
            labelAcumulado = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelCantidad = new Label();
            labelCodigo = new Label();
            button4 = new Button();
            btnGuardarIngresoVentas = new Button();
            btnLimpiarIngresoVentas = new Button();
            Codigo = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(49, 49, 68);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, cantidad, Descripcion, precio, total, fecha });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(49, 49, 68);
            dataGridView1.Location = new Point(55, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersWidth = 20;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.SteelBlue;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Size = new Size(741, 373);
            dataGridView1.TabIndex = 0;
            // 
            // labelTablaIngresoCompras
            // 
            labelTablaIngresoCompras.AutoSize = true;
            labelTablaIngresoCompras.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaIngresoCompras.Location = new Point(55, 21);
            labelTablaIngresoCompras.Name = "labelTablaIngresoCompras";
            labelTablaIngresoCompras.Size = new Size(251, 32);
            labelTablaIngresoCompras.TabIndex = 1;
            labelTablaIngresoCompras.Text = "Ingreso de Compras:";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelAcumulado);
            panel2.Location = new Point(846, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 26);
            panel2.TabIndex = 24;
            // 
            // labelAcumulado
            // 
            labelAcumulado.AutoSize = true;
            labelAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAcumulado.ForeColor = Color.White;
            labelAcumulado.Location = new Point(42, 6);
            labelAcumulado.Name = "labelAcumulado";
            labelAcumulado.Size = new Size(86, 15);
            labelAcumulado.TabIndex = 13;
            labelAcumulado.Text = "ACUMULADO:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(847, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 72);
            panel1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(-1, 26);
            label3.Name = "label3";
            label3.Size = new Size(32, 32);
            label3.TabIndex = 2;
            label3.Text = "Q";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(57, 29);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 1;
            label2.Text = "1,000.00";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.borrar;
            button3.Location = new Point(667, 81);
            button3.Name = "button3";
            button3.Size = new Size(129, 52);
            button3.TabIndex = 22;
            button3.Text = "Borrar Compra";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.edit;
            button2.Location = new Point(532, 81);
            button2.Name = "button2";
            button2.Size = new Size(131, 52);
            button2.TabIndex = 21;
            button2.Text = "Editar Compra";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.ADD;
            button1.Location = new Point(397, 81);
            button1.Name = "button1";
            button1.Size = new Size(131, 52);
            button1.TabIndex = 20;
            button1.Text = "Ingresar Compra";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 18;
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCantidad.Location = new Point(219, 87);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(97, 25);
            labelCantidad.TabIndex = 17;
            labelCantidad.Text = "Cantidad:";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCodigo.Location = new Point(55, 87);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(82, 25);
            labelCodigo.TabIndex = 16;
            labelCodigo.Text = "Código:";
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.clients;
            button4.Location = new Point(55, 550);
            button4.Name = "button4";
            button4.Size = new Size(149, 64);
            button4.TabIndex = 27;
            button4.Text = "Proveedores";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnGuardarIngresoVentas
            // 
            btnGuardarIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnGuardarIngresoVentas.Image = Properties.Resources.save;
            btnGuardarIngresoVentas.Location = new Point(473, 550);
            btnGuardarIngresoVentas.Name = "btnGuardarIngresoVentas";
            btnGuardarIngresoVentas.Size = new Size(158, 64);
            btnGuardarIngresoVentas.TabIndex = 26;
            btnGuardarIngresoVentas.Text = "Guardar Compras";
            btnGuardarIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarIngresoVentas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarIngresoVentas
            // 
            btnLimpiarIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnLimpiarIngresoVentas.Image = Properties.Resources.cleaner;
            btnLimpiarIngresoVentas.Location = new Point(637, 550);
            btnLimpiarIngresoVentas.Name = "btnLimpiarIngresoVentas";
            btnLimpiarIngresoVentas.Size = new Size(159, 64);
            btnLimpiarIngresoVentas.TabIndex = 25;
            btnLimpiarIngresoVentas.Text = "Limpiar Compras";
            btnLimpiarIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarIngresoVentas.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 60;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.Width = 60;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 300;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            // 
            // FormIngresoCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1025, 626);
            Controls.Add(button4);
            Controls.Add(btnGuardarIngresoVentas);
            Controls.Add(btnLimpiarIngresoVentas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelCantidad);
            Controls.Add(labelCodigo);
            Controls.Add(labelTablaIngresoCompras);
            Controls.Add(dataGridView1);
            Name = "FormIngresoCompras";
            Text = "INGRESO DE COMPRAS";
            Load += FormIngresoCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelTablaIngresoCompras;
        private Panel panel2;
        private Label labelAcumulado;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelCantidad;
        private Label labelCodigo;
        private Button button4;
        private Button btnGuardarIngresoVentas;
        private Button btnLimpiarIngresoVentas;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn fecha;
    }
}