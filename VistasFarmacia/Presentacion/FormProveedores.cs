using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Datos;
using Farmacia.Presentacion;
using VistasFarmacia.Datos;

namespace VistasFarmacia.Forms
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void FormClientes_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
            CargarProveedores();
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
            dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvProveedores.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }

        #region "Datos"
        D_Proveedores proveedores = new D_Proveedores();
        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            try
            {
                proveedores.Insertar(
                    txtNit.Text,
                    txtProveedor.Text,
                    txtTelefono.Text,
                    txtRepresentante.Text
                 );

                MessageBox.Show("Se guardó correctamente");
                //LimpiarCampos();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                dgvProveedores.DataSource = proveedores.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar datos. " + ex.Message, "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
