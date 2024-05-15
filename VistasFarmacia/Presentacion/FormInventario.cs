
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
            dgvProductos.CellFormatting += dgvProductos_CellFormatting!;
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ListarProductos();
            CalcularTotal();
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
                Nombre = fila.Cells[1].Value.ToString() ?? ""
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
                "Borrar el producto: " + dgvProductos.CurrentRow.Cells["producto"].Value,
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (consulta != DialogResult.Yes) return;

            // Si se confirma la eliminacion
            int productoSeleccionado = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }

        #endregion

        #region "Helpers
        private void CalcularTotal()
        {
            decimal total = 0;

            // Multiplicar la columna 2 con la columna 3 para todas las filas
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                decimal stock = Convert.ToDecimal(row.Cells["stock"].Value);
                decimal precioCompra = Convert.ToDecimal(row.Cells["precio_compra"].Value);

                total += stock * precioCompra;
            }

            // Asignar el total al Label
            lblTotal.Text = total.ToString();
        }

        // Alerta de Stock
        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Columna a cambiar color
            int columnIndex = 5;

            // Si la celda actual pertenece a la columna
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda actual
                int valorCelda;
                if (int.TryParse(e.Value?.ToString(), out valorCelda))
                {
                    // Si el valor es menor que 5, pintar la celda en rojo
                    if (valorCelda <= 5)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else if (valorCelda > 5 && valorCelda < 20)
                    {
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
        #endregion
    }
}
