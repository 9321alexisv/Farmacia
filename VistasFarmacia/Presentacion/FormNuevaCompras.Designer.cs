namespace VistasFarmacia.Forms
{
    partial class FormNuevaCompras
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
            total = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
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
            btnGuardarIngresoVentas = new Button();
            btnLimpiarIngresoVentas = new Button();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, cantidad, Descripcion, precio, total, fecha });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(49, 49, 68);
            dataGridView1.Location = new Point(63, 209);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 20;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(847, 497);
            dataGridView1.TabIndex = 0;
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
            Descripcion.Width = 300;
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
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 125;
            // 
            // labelTablaIngresoCompras
            // 
            labelTablaIngresoCompras.AutoSize = true;
            labelTablaIngresoCompras.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTablaIngresoCompras.Location = new Point(63, 28);
            labelTablaIngresoCompras.Name = "labelTablaIngresoCompras";
            labelTablaIngresoCompras.Size = new Size(227, 41);
            labelTablaIngresoCompras.TabIndex = 1;
            labelTablaIngresoCompras.Text = "Nueva Compra";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelAcumulado);
            panel2.Location = new Point(967, 20);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 35);
            panel2.TabIndex = 24;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(968, 19);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 96);
            panel1.TabIndex = 23;
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
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Farmacia.Properties.Resources.borrar;
            button3.Location = new Point(762, 108);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(147, 69);
            button3.TabIndex = 22;
            button3.Text = "Borrar Compra";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Farmacia.Properties.Resources.edit;
            button2.Location = new Point(608, 108);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(150, 69);
            button2.TabIndex = 21;
            button2.Text = "Editar Compra";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Farmacia.Properties.Resources.ADD;
            button1.Location = new Point(454, 108);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 69);
            button1.TabIndex = 20;
            button1.Text = "Ingresar Compra";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 119);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 27);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 123);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 27);
            textBox1.TabIndex = 18;
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCantidad.Location = new Point(250, 116);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(123, 32);
            labelCantidad.TabIndex = 17;
            labelCantidad.Text = "Cantidad:";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCodigo.Location = new Point(63, 116);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(103, 32);
            labelCodigo.TabIndex = 16;
            labelCodigo.Text = "Código:";
            // 
            // btnGuardarIngresoVentas
            // 
            btnGuardarIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnGuardarIngresoVentas.Image = Farmacia.Properties.Resources.save;
            btnGuardarIngresoVentas.Location = new Point(541, 733);
            btnGuardarIngresoVentas.Margin = new Padding(3, 4, 3, 4);
            btnGuardarIngresoVentas.Name = "btnGuardarIngresoVentas";
            btnGuardarIngresoVentas.Size = new Size(181, 85);
            btnGuardarIngresoVentas.TabIndex = 26;
            btnGuardarIngresoVentas.Text = "Guardar Compras";
            btnGuardarIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarIngresoVentas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarIngresoVentas
            // 
            btnLimpiarIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnLimpiarIngresoVentas.Image = Farmacia.Properties.Resources.cleaner;
            btnLimpiarIngresoVentas.Location = new Point(728, 733);
            btnLimpiarIngresoVentas.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarIngresoVentas.Name = "btnLimpiarIngresoVentas";
            btnLimpiarIngresoVentas.Size = new Size(182, 85);
            btnLimpiarIngresoVentas.TabIndex = 25;
            btnLimpiarIngresoVentas.Text = "Limpiar Compras";
            btnLimpiarIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarIngresoVentas.UseVisualStyleBackColor = true;
            // 
            // FormNuevaCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1171, 835);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNuevaCompras";
            Text = "Nueva Compra";
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