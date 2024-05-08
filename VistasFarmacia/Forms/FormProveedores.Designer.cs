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
            labelClientes = new Label();
            dataGridViewClientes = new DataGridView();
            labelId = new Label();
            textBoxID = new TextBox();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            textBoxNIT = new TextBox();
            labelNit = new Label();
            buttonSaveClient = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            labelClientes.ForeColor = SystemColors.ControlLightLight;
            labelClientes.Location = new Point(68, 9);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(179, 37);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Proveedores:";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = Color.FromArgb(49, 49, 68);
            dataGridViewClientes.BorderStyle = BorderStyle.None;
            dataGridViewClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 49, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.GridColor = Color.FromArgb(49, 49, 68);
            dataGridViewClientes.Location = new Point(75, 106);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewClientes.Size = new Size(672, 365);
            dataGridViewClientes.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(75, 69);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 21);
            labelId.TabIndex = 2;
            labelId.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(112, 67);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(59, 23);
            textBoxID.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(260, 67);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(218, 23);
            textBoxNombre.TabIndex = 5;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(177, 68);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(79, 21);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Empresa:";
            // 
            // textBoxNIT
            // 
            textBoxNIT.Location = new Point(531, 67);
            textBoxNIT.Name = "textBoxNIT";
            textBoxNIT.Size = new Size(70, 23);
            textBoxNIT.TabIndex = 7;
            // 
            // labelNit
            // 
            labelNit.AutoSize = true;
            labelNit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNit.ForeColor = Color.White;
            labelNit.Location = new Point(484, 64);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(41, 21);
            labelNit.TabIndex = 6;
            labelNit.Text = "NIT:";
            // 
            // buttonSaveClient
            // 
            buttonSaveClient.FlatStyle = FlatStyle.Flat;
            buttonSaveClient.Image = Properties.Resources.ADD;
            buttonSaveClient.Location = new Point(619, 38);
            buttonSaveClient.Name = "buttonSaveClient";
            buttonSaveClient.Size = new Size(129, 59);
            buttonSaveClient.TabIndex = 13;
            buttonSaveClient.Text = "Guardar Proveedor";
            buttonSaveClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSaveClient.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.HeaderText = "Empresa";
            Column2.Name = "Column2";
            Column2.Width = 500;
            // 
            // Column3
            // 
            Column3.HeaderText = "NIT";
            Column3.Name = "Column3";
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(800, 492);
            Controls.Add(buttonSaveClient);
            Controls.Add(textBoxNIT);
            Controls.Add(labelNit);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(textBoxID);
            Controls.Add(labelId);
            Controls.Add(dataGridViewClientes);
            Controls.Add(labelClientes);
            Name = "FormProveedores";
            Text = "FormClientes";
            Load += FormClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClientes;
        private DataGridView dataGridViewClientes;
        private Label labelId;
        private TextBox textBoxID;
        private TextBox textBoxNombre;
        private Label labelNombre;
        private TextBox textBoxNIT;
        private Label labelNit;
        private Button buttonSaveClient;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}