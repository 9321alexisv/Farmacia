
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
            lblTelefono.ForeColor = ThemeColor.SecondaryColor;

            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvClientes.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }

        #region "Datos"
        readonly D_Clientes clientes = new();

        private void MostrarClientes()
        {
            try
            {
                dgvClientes.DataSource = D_Clientes.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar datos. " + ex.Message, "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNit.TextLength < 1 || txtNombre.TextLength < 1 || txtTelefono.TextLength < 1)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if(txtId.TextLength == 0)
                {
                    D_Clientes.Insertar(
                        txtNit.Text,
                        txtNombre.Text,
                        txtTelefono.Text
                    );
                }

                if(txtId.TextLength > 0)
                {
                    clientes.Editar(
                        Convert.ToInt32(txtId.Text),
                        txtNit.Text,
                        txtNombre.Text,
                        txtTelefono.Text
                    );
                }

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
            LlenarCampos(dgvClientes.CurrentRow);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count < 0)
            {
                MessageBox.Show("Ningun regisro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DialogResult confirmar = MessageBox.Show("Eliminar el cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes) return;

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            clientes.Eliminar(idCliente);
            MostrarClientes();
        }

        #endregion

        #region "Helpers"
        public void LimpiarCampos()
        {
            txtId.Clear();
            txtNit.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        public void LlenarCampos(DataGridViewRow fila)
        {
            if (fila == null) return;
            txtId.Text = fila.Cells[0].Value.ToString();
            txtNit.Text = fila.Cells[1].Value.ToString();
            txtNombre.Text = fila.Cells[2].Value.ToString();
            txtTelefono.Text = fila.Cells[3].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion
    }
}
