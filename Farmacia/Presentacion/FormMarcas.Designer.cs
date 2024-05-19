namespace VistasFarmacia.Forms
{
    partial class FormMarcas
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
            lblMarcas = new Label();
            dgvMarcas = new DataGridView();
            txtNombre = new TextBox();
            labelNombre = new Label();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtRepresentante = new TextBox();
            labelNit = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // lblMarcas
            // 
            lblMarcas.AutoSize = true;
            lblMarcas.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            lblMarcas.ForeColor = SystemColors.ControlLightLight;
            lblMarcas.Location = new Point(73, 35);
            lblMarcas.Margin = new Padding(4, 0, 4, 0);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(135, 46);
            lblMarcas.TabIndex = 0;
            lblMarcas.Text = "Marcas";
            // 
            // dgvMarcas
            // 
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.AllowUserToDeleteRows = false;
            dgvMarcas.AllowUserToOrderColumns = true;
            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcas.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvMarcas.BorderStyle = BorderStyle.None;
            dgvMarcas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMarcas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMarcas.EnableHeadersVisualStyles = false;
            dgvMarcas.GridColor = Color.FromArgb(49, 49, 68);
            dgvMarcas.Location = new Point(73, 148);
            dgvMarcas.Margin = new Padding(4, 6, 4, 6);
            dgvMarcas.MultiSelect = false;
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.ReadOnly = true;
            dgvMarcas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMarcas.RowHeadersVisible = false;
            dgvMarcas.RowHeadersWidth = 51;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.Size = new Size(863, 454);
            dgvMarcas.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1147, 148);
            txtNombre.Margin = new Padding(4, 6, 4, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(357, 34);
            txtNombre.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(989, 148);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 28);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Farmacia.Properties.Resources.ADD;
            btnGuardar.Location = new Point(1354, 441);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
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
            txtTelefono.Location = new Point(1147, 215);
            txtTelefono.Margin = new Padding(4, 6, 4, 6);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(357, 34);
            txtTelefono.TabIndex = 15;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(989, 213);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(99, 28);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtRepresentante
            // 
            txtRepresentante.Location = new Point(1223, 289);
            txtRepresentante.Margin = new Padding(4, 6, 4, 6);
            txtRepresentante.Name = "txtRepresentante";
            txtRepresentante.Size = new Size(281, 34);
            txtRepresentante.TabIndex = 17;
            // 
            // labelNit
            // 
            labelNit.AutoSize = true;
            labelNit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNit.ForeColor = Color.White;
            labelNit.Location = new Point(989, 288);
            labelNit.Margin = new Padding(4, 0, 4, 0);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(154, 28);
            labelNit.TabIndex = 16;
            labelNit.Text = "Representante:";
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = Farmacia.Properties.Resources.edit;
            btnEditar.Location = new Point(401, 644);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
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
            btnEliminar.Location = new Point(73, 644);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
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
            btnCancelar.Location = new Point(989, 441);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 80);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormMarcas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1612, 787);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(txtRepresentante);
            Controls.Add(labelNit);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Controls.Add(dgvMarcas);
            Controls.Add(lblMarcas);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "FormMarcas";
            Text = "Marcas";
            Load += FormMarcas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarcas;
        private DataGridView dgvMarcas;
        private TextBox txtNombre;
        private Label labelNombre;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtRepresentante;
        private Label labelNit;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}