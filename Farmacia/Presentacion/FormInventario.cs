
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

        #region Load
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
                if (btns.GetType() == typeof(Button) && btns.Name != "btnEliminar")
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelTablaInventario.ForeColor = ThemeColor.SecondaryColor;
            lblTotalTitulo.BackColor = ThemeColor.SecondaryColor;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvProductos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }
        
        #endregion
        
        #region Datos
        public void ListarProductos()
        {
            try
            {
                //dgvProductos.DataSource = D_Productos.Listar();
                List<Producto> productos = D_Productos.Listar();

                // Limpiar el DataGridView
                dgvProductos.Rows.Clear();

                // Añadir filas con datos de productos
                foreach (var producto in productos)
                {
                    int rowIndex = dgvProductos.Rows.Add();
                    DataGridViewRow row = dgvProductos.Rows[rowIndex];

                    row.Cells["IdProducto"].Value = producto.IdProducto;
                    row.Cells["Producto"].Value = producto.Nombre;
                    row.Cells["IdMarca"].Value = producto.Marca.IdMarca;
                    row.Cells["Marca"].Value = producto.Marca.Nombre;
                    row.Cells["PrecioCompra"].Value = producto.PrecioCompra;
                    row.Cells["PrecioVenta"].Value = producto.PrecioVenta;
                    row.Cells["Stock"].Value = producto.Stock;
                    row.Cells["StockMinimo"].Value = producto.StockMinimo;
                }
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
                IdMarca = Convert.ToInt32(fila.Cells["IdMarca"].Value),
                Nombre = Convert.ToString(fila.Cells["Marca"].Value) ?? "",
            };

            Producto producto = new()
            {
                IdProducto = Convert.ToInt32(fila.Cells["IdProducto"].Value),
                Marca = marca,
                Nombre = Convert.ToString(fila.Cells["Producto"].Value)!,
                PrecioCompra = Convert.ToDecimal(fila.Cells["PrecioCompra"].Value),
                PrecioVenta = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value),
                Stock = Convert.ToInt32(fila.Cells["Stock"].Value),
                StockMinimo = Convert.ToInt32(fila.Cells["StockMinimo"].Value),
            };

            FormNuevoProducto formNuevoProducto = new(producto);
            formNuevoProducto.ShowDialog();
            ListarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar seleccionar de registro
            if (!VerificarFilaSeleccionada()) return;

            // Consultar si eliminar o no
            DialogResult consulta = MessageBox.Show(
                "Borrar el producto: " + dgvProductos.CurrentRow.Cells["Producto"].Value,
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (consulta != DialogResult.Yes) return;

            // Si se confirma la eliminacion
            int productoSeleccionado = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);
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
            Buscar();
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            ListarProductos();
            CalcularTotal();
        }

        #endregion

        #region Eventos
        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        #endregion

        #region Helpers
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                decimal stock = Convert.ToDecimal(row.Cells["Stock"].Value);
                decimal precioCompra = Convert.ToDecimal(row.Cells["PrecioCompra"].Value);

                total += stock * precioCompra;
            }

            // Asignar el total al Label
            lblTotal.Text = total.ToString();
        }

        // Alerta de Stock
        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Indices de las columnas de "stock" y "stock_minimo"
            int stockColumnIndex = dgvProductos.Columns["Stock"].Index;
            int stockMinimoColumnIndex = dgvProductos.Columns["StockMinimo"].Index;

            // Verificar que los índices de las columnas sean válidos y que la fila actual sea válida
            if (e.RowIndex >= 0 && e.ColumnIndex == stockColumnIndex)
            {
                // Obtener el valor de la columna "stock" para la fila actual
                var stockValue = dgvProductos.Rows[e.RowIndex].Cells[stockColumnIndex].Value;
                // Obtener el valor de la columna "stock_minimo" para la fila actual
                var stockMinimoValue = dgvProductos.Rows[e.RowIndex].Cells[stockMinimoColumnIndex].Value;

                // Verificar que ambos valores sean numéricos
                if (int.TryParse(stockValue?.ToString(), out int stock) && int.TryParse(stockMinimoValue?.ToString(), out int stockMinimo))
                {
                    // Si el stock es menor o igual al stock minimo, pintar la celda en rojo
                    if (stock <= stockMinimo)
                    {
                        e.CellStyle.BackColor = Color.Red;
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

        public void Buscar()
        {
            try
            {
                List<Producto> productos = D_Productos.BuscarPorIdNombreMarca(txtQuery.Text);

                // Limpiar el DataGridView
                dgvProductos.Rows.Clear();

                // Añadir filas con datos de productos
                foreach (var producto in productos)
                {
                    int rowIndex = dgvProductos.Rows.Add();
                    DataGridViewRow row = dgvProductos.Rows[rowIndex];

                    row.Cells["IdProducto"].Value = producto.IdProducto;
                    row.Cells["Producto"].Value = producto.Nombre;
                    row.Cells["IdMarca"].Value = producto.Marca.IdMarca;
                    row.Cells["Marca"].Value = producto.Marca.Nombre;
                    row.Cells["PrecioCompra"].Value = producto.PrecioCompra;
                    row.Cells["PrecioVenta"].Value = producto.PrecioVenta;
                    row.Cells["Stock"].Value = producto.Stock;
                    row.Cells["StockMinimo"].Value = producto.StockMinimo;
                }

                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar. " + ex.Message + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
