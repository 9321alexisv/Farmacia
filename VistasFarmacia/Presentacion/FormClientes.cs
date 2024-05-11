
using Farmacia.Presentacion;
using VistasFarmacia.Datos;

namespace VistasFarmacia.Forms
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void FormClientes_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
            MostrarClientes();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelClientes.ForeColor = ThemeColor.PrimaryColor;
            labelId.ForeColor = ThemeColor.SecondaryColor;
            labelNombre.ForeColor = ThemeColor.SecondaryColor;
            labelNit.ForeColor = ThemeColor.SecondaryColor;
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvClientes.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }

        #region "Datos"
        private void MostrarClientes()
        {
            try
            {
                D_Clientes datos = new D_Clientes();
                dgvClientes.DataSource = datos.Listar();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al mostrar datos. " + ex.Message, "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
