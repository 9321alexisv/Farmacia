
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;

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
            labelNombre.ForeColor = ThemeColor.SecondaryColor;
            labelNit.ForeColor = ThemeColor.SecondaryColor;
            lblTelefono.ForeColor = ThemeColor.SecondaryColor;

            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvClientes.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }

        #region Datos
        int idCliente = 0;

        private void MostrarClientes()
        {
            try
            {
                dgvClientes.DataSource = D_Clientes.Listar();
                dgvClientes.Columns["NombreNit"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos. " + ex.Message, "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.TextLength < 1)
            {
                MessageBox.Show("El Nombre es obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Cliente cliente = new()
                {
                    IdCliente = idCliente,
                    Nit = txtNit.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text
                };

                if (idCliente == 0) D_Clientes.Insertar(cliente);

                if(idCliente > 0) D_Clientes.Editar(cliente);

                LimpiarCampos();
                MostrarClientes();
                MessageBox.Show("Se guardó correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!VerificarFilaSeleccionada()) return;

            LlenarCampos(dgvClientes.CurrentRow);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!VerificarFilaSeleccionada()) return;

            DialogResult confirmar = MessageBox.Show("Eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes) return;

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            D_Clientes.Eliminar(idCliente);

            LimpiarCampos();
            MostrarClientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion

        #region Helpers
        public void LimpiarCampos()
        {
            idCliente = 0;
            txtNit.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        public void LlenarCampos(DataGridViewRow fila)
        {
            if (fila == null) return;

            idCliente = Convert.ToInt32(fila.Cells["IdCliente"].Value);
            txtNit.Text = Convert.ToString(fila.Cells["Nit"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells["Telefono"].Value);
        }

        public bool VerificarFilaSeleccionada()
        {
            if (dgvClientes.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ningun regisro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        #endregion
    }
}
