namespace VistasFarmacia.Forms
{
    partial class FormProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelClientes = new Label();
            dgvProveedores = new DataGridView();
            labelId = new Label();
            txtId = new TextBox();
            txtProveedor = new TextBox();
            labelNombre = new Label();
            txtNit = new TextBox();
            labelNit = new Label();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            label1 = new Label();
            txtRepresentante = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            labelClientes.ForeColor = SystemColors.ControlLightLight;
            labelClientes.Location = new Point(49, 35);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(216, 46);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Proveedores";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.GridColor = Color.FromArgb(49, 49, 68);
            dgvProveedores.Location = new Point(49, 124);
            dgvProveedores.Margin = new Padding(3, 4, 3, 4);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(694, 541);
            dgvProveedores.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(779, 123);
            labelId.Name = "labelId";
            labelId.Size = new Size(38, 28);
            labelId.TabIndex = 2;
            labelId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(899, 124);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(67, 27);
            txtId.TabIndex = 3;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(899, 247);
            txtProveedor.Margin = new Padding(3, 4, 3, 4);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(250, 27);
            txtProveedor.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(777, 247);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(115, 28);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Proveedor:";
            // 
            // txtNit
            // 
            txtNit.Location = new Point(899, 191);
            txtNit.Margin = new Padding(3, 4, 3, 4);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(250, 27);
            txtNit.TabIndex = 7;
            // 
            // labelNit
            // 
            labelNit.AutoSize = true;
            labelNit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNit.ForeColor = Color.White;
            labelNit.Location = new Point(777, 187);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(51, 28);
            labelNit.TabIndex = 6;
            labelNit.Text = "NIT:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Farmacia.Properties.Resources.ADD;
            btnGuardar.Location = new Point(899, 523);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 79);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar Proveedor";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += buttonSaveClient_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(899, 318);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 27);
            txtTelefono.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(777, 318);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 14;
            label1.Text = "Teléfono:";
            // 
            // txtRepresentante
            // 
            txtRepresentante.Location = new Point(937, 386);
            txtRepresentante.Margin = new Padding(3, 4, 3, 4);
            txtRepresentante.Name = "txtRepresentante";
            txtRepresentante.Size = new Size(212, 27);
            txtRepresentante.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(777, 386);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 16;
            label2.Text = "Representante:";
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1182, 703);
            Controls.Add(txtRepresentante);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtNit);
            Controls.Add(labelNit);
            Controls.Add(txtProveedor);
            Controls.Add(labelNombre);
            Controls.Add(txtId);
            Controls.Add(labelId);
            Controls.Add(dgvProveedores);
            Controls.Add(labelClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProveedores";
            Text = "Proveedores";
            Load += FormClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClientes;
        private DataGridView dgvProveedores;
        private Label labelId;
        private TextBox txtId;
        private TextBox txtProveedor;
        private Label labelNombre;
        private TextBox txtNit;
        private Label labelNit;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private Label label1;
        private TextBox txtRepresentante;
        private Label label2;
    }
}