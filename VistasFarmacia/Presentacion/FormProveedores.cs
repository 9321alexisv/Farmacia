
using Farmacia.Datos;
using Farmacia.Presentacion;

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
            lblTelefono.ForeColor = ThemeColor.SecondaryColor;
            lblRepresentante.ForeColor = ThemeColor.SecondaryColor;
            
            dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvProveedores.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }

        #region "Datos"
        D_Proveedores proveedores = new D_Proveedores();

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            // Verificar campos nulos
            if (txtNit.TextLength < 1 || txtProveedor.TextLength < 1 ||
                txtTelefono.TextLength < 1 || txtRepresentante.TextLength < 1)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                // Nuevo
                if (txtId.TextLength == 0)
                {
                    proveedores.Insertar(
                        txtNit.Text,
                        txtProveedor.Text,
                        txtTelefono.Text,
                        txtRepresentante.Text
                     );
                }
                else
                {
                    // Actualizar
                    proveedores.Actualizar(
                        Convert.ToInt32(txtId.Text),
                        txtNit.Text,
                        txtProveedor.Text,
                        txtTelefono.Text,
                        txtRepresentante.Text
                    );
                }

                LimpiarCampos();
                CargarProveedores();
                MessageBox.Show($"Se guardo correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error al mostrar datos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Eliminar registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (pregunta == DialogResult.Yes)
            {
                if (dgvProveedores.SelectedRows.Count > 0)
                {
                    int idProveedor = Convert.ToInt32(dgvProveedores.CurrentRow.Cells[0].Value);
                    proveedores.Eliminar(idProveedor);

                    CargarProveedores();
                    MessageBox.Show("Eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccionar registro a eliminar.", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CargarCampos(dgvProveedores.CurrentRow);
        }

        #endregion

        #region "Helpers"
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNit.Clear();
            txtProveedor.Clear();
            txtTelefono.Clear();
            txtRepresentante.Clear();
        }

        public void CargarCampos(DataGridViewRow fila)
        {
            LimpiarCampos();
            // Copiar los valores de la fila seleccionada a los campos de texto.
            txtId.Text = fila.Cells[0].Value.ToString();
            txtNit.Text = fila.Cells[1].Value.ToString();
            txtProveedor.Text = fila.Cells[2].Value.ToString();
            txtTelefono.Text = fila.Cells[3].Value.ToString();
            txtRepresentante.Text = fila.Cells[4].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion
    }
}