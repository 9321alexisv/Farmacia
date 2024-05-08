namespace VistasFarmacia.Forms
{
    partial class FormIngresoVentas
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            button4 = new Button();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 20;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, cantidad, Descripcion, precio, toootal, unitaria, total, fecha });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(49, 49, 68);
            dataGridView1.Location = new Point(84, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.Size = new Size(952, 390);
            dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 65;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.Width = 90;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 250;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // toootal
            // 
            toootal.HeaderText = "Total";
            toootal.Name = "toootal";
            // 
            // unitaria
            // 
            unitaria.HeaderText = "Ganancia Unitaria";
            unitaria.Name = "unitaria";
            unitaria.Width = 120;
            // 
            // total
            // 
            total.HeaderText = "Ganancia Total";
            total.Name = "total";
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            // 
            // labelTablaIngresoVentas
            // 
            labelTablaIngresoVentas.AutoSize = true;
            labelTablaIngresoVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaIngresoVentas.Location = new Point(80, 13);
            labelTablaIngresoVentas.Name = "labelTablaIngresoVentas";
            labelTablaIngresoVentas.Size = new Size(218, 32);
            labelTablaIngresoVentas.TabIndex = 1;
            labelTablaIngresoVentas.Text = "Ingreso de Ventas";
            // 
            // btnLimpiarIngresoVentas
            // 
            btnLimpiarIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnLimpiarIngresoVentas.Image = Properties.Resources.cleaner;
            btnLimpiarIngresoVentas.Location = new Point(887, 539);
            btnLimpiarIngresoVentas.Name = "btnLimpiarIngresoVentas";
            btnLimpiarIngresoVentas.Size = new Size(149, 64);
            btnLimpiarIngresoVentas.TabIndex = 2;
            btnLimpiarIngresoVentas.Text = "Limpiar Ventas";
            btnLimpiarIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarIngresoVentas.UseVisualStyleBackColor = true;
            btnLimpiarIngresoVentas.Click += btnLimpiarIngresoVentas_Click;
            // 
            // btnGuardarIngresoVentas
            // 
            btnGuardarIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnGuardarIngresoVentas.Image = Properties.Resources.save;
            btnGuardarIngresoVentas.Location = new Point(732, 539);
            btnGuardarIngresoVentas.Name = "btnGuardarIngresoVentas";
            btnGuardarIngresoVentas.Size = new Size(149, 64);
            btnGuardarIngresoVentas.TabIndex = 3;
            btnGuardarIngresoVentas.Text = "Guardar Ventas";
            btnGuardarIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarIngresoVentas.UseVisualStyleBackColor = true;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCodigo.Location = new Point(79, 80);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(82, 25);
            labelCodigo.TabIndex = 5;
            labelCodigo.Text = "Código:";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCantidad.Location = new Point(243, 80);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(97, 25);
            labelCantidad.TabIndex = 6;
            labelCantidad.Text = "Cantidad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 23);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.ADD;
            button1.Location = new Point(421, 74);
            button1.Name = "button1";
            button1.Size = new Size(131, 52);
            button1.TabIndex = 9;
            button1.Text = "Ingresar Venta";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.edit;
            button2.Location = new Point(556, 74);
            button2.Name = "button2";
            button2.Size = new Size(131, 52);
            button2.TabIndex = 10;
            button2.Text = "Editar Venta";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.borrar;
            button3.Location = new Point(691, 74);
            button3.Name = "button3";
            button3.Size = new Size(129, 52);
            button3.TabIndex = 11;
            button3.Text = "Borrar Venta";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.clients;
            button4.Location = new Point(85, 539);
            button4.Name = "button4";
            button4.Size = new Size(149, 64);
            button4.TabIndex = 12;
            button4.Text = "Clientes";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(870, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 72);
            panel1.TabIndex = 14;
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
            // panel2
            // 
            panel2.Controls.Add(labelAcumulado);
            panel2.Location = new Point(869, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 26);
            panel2.TabIndex = 15;
            // 
            // FormIngresoVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1106, 633);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button4);
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
            Name = "FormIngresoVentas";
            Text = "INGRESO DE VENTAS";
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
        private Button button4;
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