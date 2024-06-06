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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelClientes = new Label();
            dgvProveedores = new DataGridView();
            txtNombre = new TextBox();
            labelNombre = new Label();
            txtNit = new TextBox();
            labelNit = new Label();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtRepresentante = new TextBox();
            lblRepresentante = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            labelClientes.ForeColor = SystemColors.ControlLightLight;
            labelClientes.Location = new Point(49, 27);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(216, 46);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Proveedores";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AllowUserToOrderColumns = true;
            dgvProveedores.AllowUserToResizeRows = false;
            dgvProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.GridColor = Color.FromArgb(49, 49, 68);
            dgvProveedores.Location = new Point(49, 106);
            dgvProveedores.Margin = new Padding(3, 4, 3, 4);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(837, 575);
            dgvProveedores.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(1037, 180);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(304, 34);
            txtNombre.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(916, 180);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 28);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre:";
            // 
            // txtNit
            // 
            txtNit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNit.Font = new Font("Segoe UI", 12F);
            txtNit.Location = new Point(1037, 120);
            txtNit.Margin = new Padding(3, 4, 3, 4);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(304, 34);
            txtNit.TabIndex = 7;
            // 
            // labelNit
            // 
            labelNit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNit.AutoSize = true;
            labelNit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNit.ForeColor = Color.White;
            labelNit.Location = new Point(916, 120);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(51, 28);
            labelNit.TabIndex = 6;
            labelNit.Text = "NIT:";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.FlatAppearance.BorderColor = Color.LimeGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Image = Farmacia.Properties.Resources._new;
            btnGuardar.Location = new Point(1191, 485);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 65);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += buttonSaveClient_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(1037, 251);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(304, 34);
            txtTelefono.TabIndex = 15;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(916, 251);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(99, 28);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtRepresentante
            // 
            txtRepresentante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRepresentante.Font = new Font("Segoe UI", 12F);
            txtRepresentante.Location = new Point(1075, 319);
            txtRepresentante.Margin = new Padding(3, 4, 3, 4);
            txtRepresentante.Name = "txtRepresentante";
            txtRepresentante.Size = new Size(266, 34);
            txtRepresentante.TabIndex = 17;
            // 
            // lblRepresentante
            // 
            lblRepresentante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRepresentante.AutoSize = true;
            lblRepresentante.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRepresentante.ForeColor = Color.White;
            lblRepresentante.Location = new Point(916, 319);
            lblRepresentante.Name = "lblRepresentante";
            lblRepresentante.Size = new Size(154, 28);
            lblRepresentante.TabIndex = 16;
            lblRepresentante.Text = "Representante:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.FlatAppearance.BorderColor = Color.Silver;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Image = Farmacia.Properties.Resources.clear;
            btnLimpiar.Location = new Point(916, 485);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 65);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Cancelar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Farmacia.Properties.Resources.delete;
            btnEliminar.Location = new Point(47, 709);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 65);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Farmacia.Properties.Resources.edit;
            btnEditar.Location = new Point(249, 709);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 65);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1397, 803);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtRepresentante);
            Controls.Add(lblRepresentante);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(btnGuardar);
            Controls.Add(txtNit);
            Controls.Add(labelNit);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
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
        private TextBox txtNombre;
        private Label labelNombre;
        private TextBox txtNit;
        private Label labelNit;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtRepresentante;
        private Label lblRepresentante;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
    }
}