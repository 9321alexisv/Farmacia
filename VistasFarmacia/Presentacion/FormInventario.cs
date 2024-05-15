
using Farmacia.Datos;
using Farmacia.Presentacion;
using Farmacia.Presentacion.Reportes;
using VistasFarmacia.Entidad;

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
            Producto producto = new();
            FormNuevoProducto formNuevoProducto = new FormNuevoProducto(producto);
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

            DataGridViewRow fila = dgvProductos.CurrentRow;
            Proveedor proveedor = new()
            {
                IdProveedor = Convert.ToInt32(fila.Cells[1].Value),
            };

            Producto producto = new()
            {
                IdProducto = Convert.ToInt32(fila.Cells[0].Value),
                ObjProveedor = proveedor,
                Nombre = fila.Cells[2].Value.ToString() ?? "",
                PrecioCompra = Convert.ToDecimal(fila.Cells[3].Value),
                PrecioVenta = Convert.ToDecimal(fila.Cells[4].Value),
                Stock = Convert.ToInt32(fila.Cells[5].Value),
            };

            FormNuevoProducto formNuevoProducto = new(producto);
            formNuevoProducto.Show();
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportesClosedXML reportes = new();
            reportes.Excel("Inventario", dgvProductos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.DataSource = productos.BuscarPorNombre(txtQuery.Text);

            } catch(Exception ex)
            {
                MessageBox.Show("Error al buscar. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }
    }
    #endregion

}
