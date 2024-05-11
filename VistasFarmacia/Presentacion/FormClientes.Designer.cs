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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            labelClientes = new Label();
            dgvClientes = new DataGridView();
            labelId = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            labelNombre = new Label();
            buttonSaveClient = new Button();
            txtTelefono = new TextBox();
            label1 = new Label();
            txtNit = new TextBox();
            labelNit = new Label();
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
            dgvClientes.BackgroundColor = Color.FromArgb(49, 49, 68);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.FromArgb(49, 49, 68);
            dgvClientes.Location = new Point(53, 106);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(682, 556);
            dgvClientes.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(770, 108);
            labelId.Name = "labelId";
            labelId.Size = new Size(38, 28);
            labelId.TabIndex = 2;
            labelId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(885, 109);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(67, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(885, 242);
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
            labelNombre.Location = new Point(770, 242);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 28);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre:";
            // 
            // buttonSaveClient
            // 
            buttonSaveClient.FlatStyle = FlatStyle.Flat;
            buttonSaveClient.Image = Farmacia.Properties.Resources.ADD;
            buttonSaveClient.Location = new Point(885, 482);
            buttonSaveClient.Margin = new Padding(3, 4, 3, 4);
            buttonSaveClient.Name = "buttonSaveClient";
            buttonSaveClient.Size = new Size(161, 72);
            buttonSaveClient.TabIndex = 13;
            buttonSaveClient.Text = "Guardar Cliente";
            buttonSaveClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSaveClient.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(885, 315);
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
            label1.Location = new Point(770, 314);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 14;
            label1.Text = "Teléfono:";
            // 
            // txtNit
            // 
            txtNit.Location = new Point(885, 181);
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
            labelNit.Location = new Point(770, 177);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(51, 28);
            labelNit.TabIndex = 16;
            labelNit.Text = "NIT:";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1182, 703);
            Controls.Add(txtNit);
            Controls.Add(labelNit);
            Controls.Add(txtTelefono);
            Controls.Add(label1);
            Controls.Add(buttonSaveClient);
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
        private Button buttonSaveClient;
        private TextBox txtTelefono;
        private Label label1;
        private TextBox txtNit;
        private Label labelNit;
    }
}