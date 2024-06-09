
using Farmacia.Datos;
using Farmacia.Entidad;
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
                if (btns.GetType() == typeof(Button) && btns.Name != "btnEliminar")
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            labelClientes.ForeColor = ThemeColor.PrimaryColor;
            labelNombre.ForeColor = ThemeColor.SecondaryColor;
            labelNit.ForeColor = ThemeColor.SecondaryColor;
            lblTelefono.ForeColor = ThemeColor.SecondaryColor;
            lblRepresentante.ForeColor = ThemeColor.SecondaryColor;
            
            dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvProveedores.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }

        #region Datos
        int idProveedor = 0;

        private void CargarProveedores()
        {
            try
            {
                dgvProveedores.DataSource = D_Proveedores.Listar();
                dgvProveedores.Columns["NombreNit"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos. " + ex.Message + ex.InnerException!.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones
        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            // Verificar campos nulos
            if (txtNombre.TextLength < 1)
            {
                MessageBox.Show("El Nombre es obligatorio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Proveedor proveedor = new()
            {
                IdProveedor = idProveedor,
                Nit = txtNit.Text,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Representante = txtRepresentante.Text,
            };

            try
            {
                // Nuevo
                if (idProveedor == 0) D_Proveedores.Insertar(proveedor);

                // Actualizar
                if (idProveedor > 0) D_Proveedores.Actualizar(proveedor); 

                LimpiarCampos();
                CargarProveedores();

                MessageBox.Show($"Se guardo correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!VerificarFilaSeleccionada()) return;
            
            DialogResult pregunta = MessageBox.Show("Eliminar registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (pregunta != DialogResult.Yes) return;
            
            int idProveedor = Convert.ToInt32(dgvProveedores.CurrentRow.Cells[0].Value);
            D_Proveedores.Eliminar(idProveedor);
            
            CargarProveedores();
            
            MessageBox.Show("Eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!VerificarFilaSeleccionada()) return; 

            CargarCampos(dgvProveedores.CurrentRow);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion

        #region "Helpers"
        private void LimpiarCampos()
        {
            idProveedor = 0;
            txtNit.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtRepresentante.Clear();
        }

        public void CargarCampos(DataGridViewRow fila)
        {
            if(fila == null) return;
            idProveedor = Convert.ToInt32(fila.Cells["IdProveedor"].Value);
            txtNit.Text = Convert.ToString(fila.Cells["Nit"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells["Telefono"].Value);
            txtRepresentante.Text = Convert.ToString(fila.Cells["Representante"].Value);
        }

        public bool VerificarFilaSeleccionada()
        {
            if (dgvProveedores.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ningun registro seleccionado.", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        #endregion
    }
}