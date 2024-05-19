namespace VistasFarmacia.Forms
{
    partial class FormClientes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelClientes = new Label();
            dgvClientes = new DataGridView();
            labelId = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            labelNombre = new Label();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtNit = new TextBox();
            labelNit = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            labelClientes.ForeColor = SystemColors.ControlLightLight;
            labelClientes.Location = new Point(53, 25);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(148, 46);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.FromArgb(49, 49, 68);
            dgvClientes.Location = new Point(53, 106);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(826, 556);
            dgvClientes.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(946, 113);
            labelId.Name = "labelId";
            labelId.Size = new Size(38, 28);
            labelId.TabIndex = 2;
            labelId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(1061, 114);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(67, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1061, 247);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(946, 247);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 28);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Farmacia.Properties.Resources.ADD;
            btnGuardar.Location = new Point(1161, 442);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 80);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(1061, 320);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 27);
            txtTelefono.TabIndex = 15;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(946, 319);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(99, 28);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtNit
            // 
            txtNit.Location = new Point(1061, 186);
            txtNit.Margin = new Padding(3, 4, 3, 4);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(250, 27);
            txtNit.TabIndex = 17;
            // 
            // labelNit
            // 
            labelNit.AutoSize = true;
            labelNit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNit.ForeColor = Color.White;
            labelNit.Location = new Point(946, 182);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(51, 28);
            labelNit.TabIndex = 16;
            labelNit.Text = "NIT:";
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = Farmacia.Properties.Resources.edit;
            btnEditar.Location = new Point(287, 696);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 80);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = Farmacia.Properties.Resources.borrar;
            btnEliminar.Location = new Point(53, 696);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 80);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = Farmacia.Properties.Resources.cleaner;
            btnCancelar.Location = new Point(946, 442);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 80);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1382, 803);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(txtNit);
            Controls.Add(labelNit);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Controls.Add(txtId);
            Controls.Add(labelId);
            Controls.Add(dgvClientes);
            Controls.Add(labelClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormClientes";
            Text = "Clientes";
            Load += FormClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClientes;
        private DataGridView dgvClientes;
        private Label labelId;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label labelNombre;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtNit;
        private Label labelNit;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}