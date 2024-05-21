
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;
using Farmacia.Presentacion.Reportes;

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
            panel2.BackColor = ThemeColor.SecondaryColor;
        }

        #region Datos
        public void ListarProductos()
        {
            try
            {
                dgvProductos.DataSource = D_Productos.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos. " + ex.Message + ex.InnerException!.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNuevoProducto formNuevoProducto = new(null);
            formNuevoProducto.ShowDialog();
            ListarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar seleccion de producto
            if (!VerificarFilaSeleccionada()) return;

            DataGridViewRow fila = dgvProductos.CurrentRow;

            Marca marca = new()
            {
                IdMarca = Convert.ToInt32(fila.Cells["id_marca"].Value),
                Nombre = Convert.ToString(fila.Cells["marca"].Value) ?? "",
            };

            Producto producto = new()
            {
                IdProducto = Convert.ToInt32(fila.Cells["id_producto"].Value),
                Marca = marca,
                Nombre = Convert.ToString(fila.Cells["producto"].Value)!,
                PrecioCompra = Convert.ToDecimal(fila.Cells["precio_compra"].Value),
                PrecioVenta = Convert.ToDecimal(fila.Cells["precio_venta"].Value),
                Stock = Convert.ToInt32(fila.Cells["stock"].Value),
                StockMinimo = Convert.ToInt32(fila.Cells["stock_minimo"].Value),
            };

            FormNuevoProducto formNuevoProducto = new(producto);
            formNuevoProducto.ShowDialog();
            ListarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar seleccionar de registro
            if(!VerificarFilaSeleccionada()) return;

            // Consultar si eliminar o no
            DialogResult consulta = MessageBox.Show(
                "Borrar el producto: " + dgvProductos.CurrentRow.Cells["producto"].Value,
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (consulta != DialogResult.Yes) return;

            // Si se confirma la eliminacion
            int productoSeleccionado = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);
            bool resultado = D_Productos.Eliminar(productoSeleccionado);
            if (resultado)
            {
                MessageBox.Show("Eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProductos();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount == 0) return;

            ReportesClosedXML reportes = new();
            reportes.Excel("Inventario", dgvProductos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.DataSource = D_Productos.BuscarPorIdNombreMarca(txtQuery.Text);
                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar. " + ex.Message + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            ListarProductos();
            CalcularTotal();
        }

        #endregion

        #region Helpers
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
                if (int.TryParse(e.Value?.ToString(), out int valorCelda))
                {
                    // Si el valor es menor que 5, pintar la celda en rojo
                    if (valorCelda <= 5)
                    {
                        e.CellStyle!.BackColor = Color.Red;
                    }
                    else if (valorCelda > 5 && valorCelda < 20)
                    {
                        e.CellStyle!.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        public bool VerificarFilaSeleccionada()
        {
            if (dgvProductos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ningún producto seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion
    }
}
