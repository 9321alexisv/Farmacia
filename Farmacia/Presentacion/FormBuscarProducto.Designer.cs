namespace Farmacia.Presentacion
{
    partial class FormBuscarProducto
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
            listBoxProductos = new ListBox();
            txtBusqueda = new TextBox();
            SuspendLayout();
            // 
            // listBoxProductos
            // 
            listBoxProductos.Font = new Font("Segoe UI", 12F);
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.ItemHeight = 28;
            listBoxProductos.Location = new Point(12, 103);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(741, 228);
            listBoxProductos.TabIndex = 0;
            listBoxProductos.KeyDown += listBoxProductos_KeyDown;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Segoe UI", 12F);
            txtBusqueda.Location = new Point(235, 38);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(296, 34);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            txtBusqueda.KeyDown += txtBusqueda_KeyDown;
            // 
            // FormBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 360);
            Controls.Add(txtBusqueda);
            Controls.Add(listBoxProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBuscarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBuscarProducto";
            Shown += FormBuscarProducto_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProductos;
        private TextBox txtBusqueda;
    }
}