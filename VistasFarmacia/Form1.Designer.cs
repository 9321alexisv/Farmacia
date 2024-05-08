namespace VistasFarmacia
{
    partial class Form1
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
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnIngresoCompras);
            panelMenu.Controls.Add(btnCompras);
            panelMenu.Controls.Add(btnIngresoVentas);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 520);
            panelMenu.TabIndex = 0;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInventario.ForeColor = SystemColors.ControlLightLight;
            btnInventario.Image = Properties.Resources.inventario;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 315);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(10, 0, 0, 0);
            btnInventario.Size = new Size(220, 60);
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
            btnIngresoCompras.Image = Properties.Resources.ingresoCompras;
            btnIngresoCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresoCompras.Location = new Point(0, 255);
            btnIngresoCompras.Name = "btnIngresoCompras";
            btnIngresoCompras.Padding = new Padding(10, 0, 0, 0);
            btnIngresoCompras.Size = new Size(220, 60);
            btnIngresoCompras.TabIndex = 4;
            btnIngresoCompras.Text = "INGRESO COMPRA";
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
            btnCompras.Image = Properties.Resources.compras;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 195);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new Padding(10, 0, 0, 0);
            btnCompras.Size = new Size(220, 60);
            btnCompras.TabIndex = 3;
            btnCompras.Text = "COMPRAS";
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
            btnIngresoVentas.Image = Properties.Resources.ingresoVentas;
            btnIngresoVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresoVentas.Location = new Point(0, 135);
            btnIngresoVentas.Name = "btnIngresoVentas";
            btnIngresoVentas.Padding = new Padding(10, 0, 0, 0);
            btnIngresoVentas.Size = new Size(220, 60);
            btnIngresoVentas.TabIndex = 2;
            btnIngresoVentas.Text = "INGRESO VENTA";
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
            btnVentas.Image = Properties.Resources.ventas1;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 75);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 0, 0);
            btnVentas.Size = new Size(220, 60);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "VENTAS";
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
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 75);
            panelLogo.TabIndex = 0;
            // 
            // labelFarmacia
            // 
            labelFarmacia.AutoSize = true;
            labelFarmacia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelFarmacia.ForeColor = Color.White;
            labelFarmacia.Location = new Point(3, 25);
            labelFarmacia.Name = "labelFarmacia";
            labelFarmacia.Size = new Size(194, 21);
            labelFarmacia.TabIndex = 0;
            labelFarmacia.Text = "FARMACIA CANDELARIA";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelTitleBar.Controls.Add(btnHome);
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(805, 75);
            panelTitleBar.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = Properties.Resources.home;
            btnHome.Location = new Point(6, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 52);
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
            labelTitle.Location = new Point(340, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(82, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "INICIO";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 75);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(805, 445);
            panelDesktopPane.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.logo5;
            pictureBox1.Location = new Point(124, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1025, 520);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
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
    }
}
