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
            textBoxID = new TextBox();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            textBoxNIT = new TextBox();
            labelNit = new Label();
            buttonSaveClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            labelClientes.ForeColor = SystemColors.ControlLightLight;
            labelClientes.Location = new Point(78, 12);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(157, 46);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Clientes:";
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
            dgvClientes.Location = new Point(86, 141);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(768, 487);
            dgvClientes.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(86, 92);
            labelId.Name = "labelId";
            labelId.Size = new Size(38, 28);
            labelId.TabIndex = 2;
            labelId.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(128, 89);
            textBoxID.Margin = new Padding(3, 4, 3, 4);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(67, 27);
            textBoxID.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(297, 89);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(249, 27);
            textBoxNombre.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(202, 91);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 28);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre:";
            // 
            // textBoxNIT
            // 
            textBoxNIT.Location = new Point(607, 89);
            textBoxNIT.Margin = new Padding(3, 4, 3, 4);
            textBoxNIT.Name = "textBoxNIT";
            textBoxNIT.Size = new Size(79, 27);
            textBoxNIT.TabIndex = 7;
            // 
            // labelNit
            // 
            labelNit.AutoSize = true;
            labelNit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNit.ForeColor = Color.White;
            labelNit.Location = new Point(553, 85);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(51, 28);
            labelNit.TabIndex = 6;
            labelNit.Text = "NIT:";
            // 
            // buttonSaveClient
            // 
            buttonSaveClient.FlatStyle = FlatStyle.Flat;
            buttonSaveClient.Image = Properties.Resources.ADD;
            buttonSaveClient.Location = new Point(694, 57);
            buttonSaveClient.Margin = new Padding(3, 4, 3, 4);
            buttonSaveClient.Name = "buttonSaveClient";
            buttonSaveClient.Size = new Size(161, 72);
            buttonSaveClient.TabIndex = 13;
            buttonSaveClient.Text = "Guardar Cliente";
            buttonSaveClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSaveClient.UseVisualStyleBackColor = true;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(914, 656);
            Controls.Add(buttonSaveClient);
            Controls.Add(textBoxNIT);
            Controls.Add(labelNit);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(textBoxID);
            Controls.Add(labelId);
            Controls.Add(dgvClientes);
            Controls.Add(labelClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClientes;
        private DataGridView dgvClientes;
        private Label labelId;
        private TextBox textBoxID;
        private TextBox textBoxNombre;
        private Label labelNombre;
        private TextBox textBoxNIT;
        private Label labelNit;
        private Button buttonSaveClient;
    }
}