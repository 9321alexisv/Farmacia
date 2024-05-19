
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;

namespace VistasFarmacia.Forms
{
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            LoadTheme();
            MostrarRegistros();
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

            lblMarcas.ForeColor = ThemeColor.PrimaryColor;
            labelNombre.ForeColor = ThemeColor.SecondaryColor;
            labelNit.ForeColor = ThemeColor.SecondaryColor;
            lblTelefono.ForeColor = ThemeColor.SecondaryColor;

            dgvMarcas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMarcas.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvMarcas.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMarcas.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }

        #region Datos
        int idMarca = 0;

        private void MostrarRegistros()
        {
            try
            {
                dgvMarcas.DataSource = D_Marcas.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.TextLength < 1 || txtTelefono.TextLength < 1 || txtRepresentante.TextLength < 1)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Marca marca = new()
                {
                    IdMarca = idMarca,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Representante = txtRepresentante.Text
                };

                // Nuevo
                if (idMarca == 0) D_Marcas.Insertar(marca);

                // Actualizar
                if (idMarca != 0) D_Marcas.Editar(marca);

                LimpiarCampos();
                MostrarRegistros();
                MessageBox.Show("Se guardó correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LlenarCampos(dgvMarcas.CurrentRow);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count < 0)
            {
                MessageBox.Show("Ningun regisro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DialogResult confirmar = MessageBox.Show("Eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes) return;

            int idMarca = Convert.ToInt32(dgvMarcas.CurrentRow.Cells[0].Value);
            D_Marcas.Eliminar(idMarca);

            MostrarRegistros();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion

        #region Helpers
        public void LimpiarCampos()
        {
            idMarca = 0;
            txtNombre.Clear();
            txtTelefono.Clear();
            txtRepresentante.Clear();
        }

        public void LlenarCampos(DataGridViewRow fila)
        {
            if (fila == null) return;
            idMarca = Convert.ToInt32(fila.Cells[0].Value);
            txtNombre.Text = fila.Cells[1].Value.ToString();
            txtTelefono.Text = fila.Cells[2].Value.ToString();
            txtRepresentante.Text = fila.Cells[3].Value.ToString();
        }

        #endregion
    }
}
