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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            labelId = new Label();
            txtId = new TextBox();
            txtProveedor = new TextBox();
            labelNombre = new Label();
            txtNit = new TextBox();
            labelNit = new Label();
            buttonSaveClient = new Button();
            txtTelefono = new TextBox();
            label1 = new Label();
            txtRepresentante = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
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
            dataGridViewClientes.Location = new Point(49, 124);
            dataGridViewClientes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.Size = new Size(694, 541);
            dataGridViewClientes.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.HeaderText = "Empresa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 500;
            // 
            // Column3
            // 
            Column3.HeaderText = "NIT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
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
            // buttonSaveClient
            // 
            buttonSaveClient.FlatStyle = FlatStyle.Flat;
            buttonSaveClient.Image = Farmacia.Properties.Resources.ADD;
            buttonSaveClient.Location = new Point(899, 523);
            buttonSaveClient.Margin = new Padding(3, 4, 3, 4);
            buttonSaveClient.Name = "buttonSaveClient";
            buttonSaveClient.Size = new Size(147, 79);
            buttonSaveClient.TabIndex = 13;
            buttonSaveClient.Text = "Guardar Proveedor";
            buttonSaveClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSaveClient.UseVisualStyleBackColor = true;
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
            Controls.Add(buttonSaveClient);
            Controls.Add(txtNit);
            Controls.Add(labelNit);
            Controls.Add(txtProveedor);
            Controls.Add(labelNombre);
            Controls.Add(txtId);
            Controls.Add(labelId);
            Controls.Add(dataGridViewClientes);
            Controls.Add(labelClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProveedores";
            Text = "Proveedores";
            Load += FormClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClientes;
        private DataGridView dataGridViewClientes;
        private Label labelId;
        private TextBox txtId;
        private TextBox txtProveedor;
        private Label labelNombre;
        private TextBox txtNit;
        private Label labelNit;
        private Button buttonSaveClient;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtTelefono;
        private Label label1;
        private TextBox txtRepresentante;
        private Label label2;
    }
}