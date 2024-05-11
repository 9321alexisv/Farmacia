namespace VistasFarmacia
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnProveedores = new Button();
            btnClientes = new Button();
            btnInventario = new Button();
            btnIngresoCompras = new Button();
            btnCompras = new Button();
            btnIngresoVentas = new Button();
            btnVentas = new Button();
            panelLogo = new Panel();
            labelFarmacia = new Label();
            panelTitleBar = new Panel();
            btnHome = new Button();
            labelTitle = new Label();
            panelDesktopPane = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnProveedores);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnIngresoCompras);
            panelMenu.Controls.Add(btnCompras);
            panelMenu.Controls.Add(btnIngresoVentas);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 693);
            panelMenu.TabIndex = 0;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProveedores.ForeColor = SystemColors.ControlLightLight;
            btnProveedores.Image = Farmacia.Properties.Resources.clients;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(0, 580);
            btnProveedores.Margin = new Padding(3, 4, 3, 4);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(11, 0, 0, 0);
            btnProveedores.Size = new Size(251, 80);
            btnProveedores.TabIndex = 7;
            btnProveedores.Text = "PROVEEDORES";
            btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Image = Farmacia.Properties.Resources.clients;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 500);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(11, 0, 0, 0);
            btnClientes.Size = new Size(251, 80);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "CLIENTES";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInventario.ForeColor = SystemColors.ControlLightLight;
            btnInventario.Image = Farmacia.Properties.Resources.inventario;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 420);
            btnInventario.Margin = new Padding(3, 4, 3, 4);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(11, 0, 0, 0);
            btnInventario.Size = new Size(251, 80);
            btnInventario.TabIndex = 5;
            btnInventario.Text = "INVENTARIO";
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnIngresoCompras
            // 
            btnIngresoCompras.Dock = DockStyle.Top;
            btnIngresoCompras.FlatAppearance.BorderSize = 0;
            btnIngresoCompras.FlatStyle = FlatStyle.Flat;
            btnIngresoCompras.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresoCompras.ForeColor = SystemColors.ControlLightLight;
            btnIngresoCompras.Image = Farmacia.Properties.Resources.ingresoCompras;
            btnIngresoCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresoCompras.Location = new Point(0, 340);
            btnIngresoCompras.Margin = new Padding(3, 4, 3, 4);
            btnIngresoCompras.Name = "btnIngresoCompras";
            btnIngresoCompras.Padding = new Padding(11, 0, 0, 0);
            btnIngresoCompras.Size = new Size(251, 80);
            btnIngresoCompras.TabIndex = 4;
            btnIngresoCompras.Text = "NUEVA COMPRA";
            btnIngresoCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresoCompras.UseVisualStyleBackColor = true;
            btnIngresoCompras.Click += btnIngresoCompras_Click;
            // 
            // btnCompras
            // 
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCompras.ForeColor = SystemColors.ControlLightLight;
            btnCompras.Image = Farmacia.Properties.Resources.compras;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 260);
            btnCompras.Margin = new Padding(3, 4, 3, 4);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new Padding(11, 0, 0, 0);
            btnCompras.Size = new Size(251, 80);
            btnCompras.TabIndex = 3;
            btnCompras.Text = "HISTORIAL COMPRAS";
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnIngresoVentas
            // 
            btnIngresoVentas.Dock = DockStyle.Top;
            btnIngresoVentas.FlatAppearance.BorderSize = 0;
            btnIngresoVentas.FlatStyle = FlatStyle.Flat;
            btnIngresoVentas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresoVentas.ForeColor = SystemColors.ControlLightLight;
            btnIngresoVentas.Image = Farmacia.Properties.Resources.ingresoVentas;
            btnIngresoVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresoVentas.Location = new Point(0, 180);
            btnIngresoVentas.Margin = new Padding(3, 4, 3, 4);
            btnIngresoVentas.Name = "btnIngresoVentas";
            btnIngresoVentas.Padding = new Padding(11, 0, 0, 0);
            btnIngresoVentas.Size = new Size(251, 80);
            btnIngresoVentas.TabIndex = 2;
            btnIngresoVentas.Text = "NUEVA VENTA";
            btnIngresoVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresoVentas.UseVisualStyleBackColor = true;
            btnIngresoVentas.Click += btnIngresoVentas_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVentas.ForeColor = SystemColors.ControlLightLight;
            btnVentas.Image = Farmacia.Properties.Resources.ventas1;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 100);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(11, 0, 0, 0);
            btnVentas.Size = new Size(251, 80);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "HISTORIAL VENTAS";
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(labelFarmacia);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(251, 100);
            panelLogo.TabIndex = 0;
            // 
            // labelFarmacia
            // 
            labelFarmacia.AutoSize = true;
            labelFarmacia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelFarmacia.ForeColor = Color.White;
            labelFarmacia.Location = new Point(3, 33);
            labelFarmacia.Name = "labelFarmacia";
            labelFarmacia.Size = new Size(244, 28);
            labelFarmacia.TabIndex = 0;
            labelFarmacia.Text = "FARMACIA CANDELARIA";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelTitleBar.Controls.Add(btnHome);
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(251, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(920, 100);
            panelTitleBar.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = Farmacia.Properties.Resources.home;
            btnHome.Location = new Point(7, 16);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 69);
            btnHome.TabIndex = 1;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(389, 33);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(102, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "INICIO";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(251, 100);
            panelDesktopPane.Margin = new Padding(3, 4, 3, 4);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(920, 593);
            panelDesktopPane.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Farmacia.Properties.Resources.logo5;
            pictureBox1.Location = new Point(142, 160);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(639, 160);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1171, 693);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInicio";
            StartPosition = FormStartPosition.Manual;
            Text = "MENU";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnVentas;
        private Button btnIngresoCompras;
        private Button btnCompras;
        private Button btnIngresoVentas;
        private Button btnInventario;
        private Panel panelTitleBar;
        private Label labelTitle;
        private Label labelFarmacia;
        private Panel panelDesktopPane;
        private Button btnHome;
        private PictureBox pictureBox1;
        private Button btnProveedores;
        private Button btnClientes;
    }
}
