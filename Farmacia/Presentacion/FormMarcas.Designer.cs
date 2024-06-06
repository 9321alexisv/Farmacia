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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvMarcas = new DataGridView();
            txtNombre = new TextBox();
            labelNombre = new Label();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // dgvMarcas
            // 
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.AllowUserToDeleteRows = false;
            dgvMarcas.AllowUserToOrderColumns = true;
            dgvMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcas.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvMarcas.BorderStyle = BorderStyle.None;
            dgvMarcas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMarcas.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMarcas.EnableHeadersVisualStyles = false;
            dgvMarcas.GridColor = Color.FromArgb(49, 49, 68);
            dgvMarcas.Location = new Point(61, 25);
            dgvMarcas.Margin = new Padding(4, 6, 4, 6);
            dgvMarcas.MultiSelect = false;
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.ReadOnly = true;
            dgvMarcas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMarcas.RowHeadersVisible = false;
            dgvMarcas.RowHeadersWidth = 51;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.Size = new Size(621, 574);
            dgvMarcas.TabIndex = 1;
            dgvMarcas.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNombre.Location = new Point(884, 62);
            txtNombre.Margin = new Padding(4, 6, 4, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(357, 34);
            txtNombre.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(726, 62);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 28);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.FlatAppearance.BorderColor = Color.LimeGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Farmacia.Properties.Resources._new;
            btnGuardar.Location = new Point(1091, 242);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 65);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Farmacia.Properties.Resources.edit;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(1091, 534);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 65);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Farmacia.Properties.Resources.delete;
            btnEliminar.Location = new Point(726, 534);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 65);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatAppearance.BorderColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = Farmacia.Properties.Resources.clear;
            btnCancelar.Location = new Point(726, 242);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 65);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormMarcas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1275, 631);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Controls.Add(dgvMarcas);
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
        private DataGridView dgvMarcas;
        private TextBox txtNombre;
        private Label labelNombre;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}