
using Farmacia.Presentacion;

namespace VistasFarmacia
{
    public partial class FormInicio : Form
    {
        //Fields
        private Button? currentButton;
        private readonly Random random;
        private int tempIndex;
        private Form activeForm;
        private Dictionary<string, Form> openForms = [];

        //Constructor
        public FormInicio()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            // Ocultar el formulario activo
            activeForm?.Hide();
            
            string formType = childForm.GetType().Name;

            // Verificar si el formulario ya está abierto
            if (openForms.TryGetValue(formType, out Form? value))
            {
                activeForm = value;
            }
            else
            {
                // Configuración del nuevo formulario hijo
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                openForms[formType] = childForm;
                activeForm = childForm;
            }

            ActivateButton(btnSender);
            activeForm.BringToFront();
            activeForm.Show();
            labelTitle.Text = activeForm.Text;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVentas(), sender);
        }

        private void btnIngresoVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNuevaVenta(), sender);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCompras(), sender);
        }

        private void btnIngresoCompras_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNuevaCompra(), sender);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInventario(), sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClientes(), sender);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProveedores(), sender);
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMarcas(), sender);
        }
    }
}
