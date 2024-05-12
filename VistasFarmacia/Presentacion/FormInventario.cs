
using Farmacia.Datos;
using Farmacia.Presentacion;

namespace VistasFarmacia.Forms
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ListarProductos();
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
            labelTablaInventario.ForeColor = ThemeColor.SecondaryColor;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvProductos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            //dataGridView1.GridColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.SecondaryColor;
        }

        #region "Datos"
        readonly D_Productos productos = new();

        public void ListarProductos()
        {
            try
            {
                dgvProductos.DataSource = productos.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar datos. " + ex.Message, "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNuevoProducto formNuevoProducto = new FormNuevoProducto();
            formNuevoProducto.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar seleccion de producto
            if (dgvProductos.SelectedRows.Count < 0)
            {
                MessageBox.Show("Ningún producto seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Editar producto

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar seleccion de producto
            if (dgvProductos.SelectedRows.Count < 0)
            {
                MessageBox.Show("Ningún producto seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Consultar si eliminar o no
            DialogResult consulta = MessageBox.Show(
                "Borrar el producto: " + dgvProductos.CurrentRow.Cells["nombre"].Value,
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (consulta != DialogResult.Yes) return;

            // Si se confirma la eliminacion
            int productoSeleccionado = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);
            bool resultado = productos.Eliminar(productoSeleccionado);
            if (resultado)
            {
                MessageBox.Show("Eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProductos();
            }
        }
    }
    #endregion

}
