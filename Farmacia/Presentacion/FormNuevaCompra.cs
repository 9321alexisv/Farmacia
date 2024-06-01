
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;

namespace VistasFarmacia.Forms
{
    public partial class FormNuevaCompra : Form
    {
        public FormNuevaCompra()
        {
            InitializeComponent();
        }

        private void FormIngresoCompras_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ListarProveedores();
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
            labelCodigo.ForeColor = ThemeColor.SecondaryColor;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvProductos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            //dataGridView1.GridColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.SecondaryColor;
        }

        #region Datos

        public void ListarProveedores()
        {
            try
            {
                cmbProveedores.DataSource = D_Proveedores.Listar();
                cmbProveedores.ValueMember = "IdProveedor";
                cmbProveedores.DisplayMember = "NombreNit";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar proveedores." + ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EliminarFilasVacias();

            if (dgvProductos.RowCount <= 1)
            {
                MessageBox.Show("Ningun producto agregado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idProveedor = Convert.ToInt32(cmbProveedores.SelectedValue);

            try
            {
                int idCompra = D_Compras.CrearCompra(idProveedor);
                bool promedio = checkPromedio.Checked;
                D_Compras.InsertarDetalleCompra(idCompra, dgvProductos, promedio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar venta " + ex.Message, "Error al guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarTabla();
            MessageBox.Show("Guardado", "Nueva compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
        }

        #endregion

        #region "Helpers"

        // ============================================================================================
        // REACCIONAR A CAMBIOS EN LA TABLA ===========================================================
        // ============================================================================================
        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Buscar producto si se ingresa el codigo en la columna ==================================
            if (dgvProductos.Columns[e.ColumnIndex].Name == "IdProducto")
            {
                // Obtén el código del producto ingresado
                if (!int.TryParse(dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int codigoProducto) || D_Productos.BuscarPorId(codigoProducto) is not Producto producto)
                {
                    MessageBox.Show("No se encontró el producto con el código ingresado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    dgvProductos.Rows.RemoveAt(e.RowIndex);
                    return;
                }

                AgregarProductoAlGrid(e.RowIndex, producto);
            }

            if (dgvProductos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                // Verificar que no se ingrese texto en la cantidad
                if (!int.TryParse(Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value), result: out _))
                {
                    dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;
                }

                // Si se ingresa una cantidad y no hay producto
                if (dgvProductos.Rows[e.RowIndex].Cells["IdProducto"].Value == null)
                {
                    //dgvProductos.Rows.RemoveAt(e.RowIndex);
                    dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = "";
                }
            }

            CalcularSubtotal(e.RowIndex);
            CalcularTotal();
        }

        private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Mostrar ventana de busqueda si se escribe dentro de la columna y fila de Producto
            if (dgvProductos.CurrentCell.ColumnIndex != 1) return;

            dgvProductos.EndEdit();

            var formBuscarProducto = new FormBuscarProducto();
            if (formBuscarProducto.ShowDialog(this) != DialogResult.OK) return;

            // Acceder al elemento seleccionado en el ListBox del formulario de búsqueda
            int idProducto = formBuscarProducto.IdProductoSeleccionado;
            if (idProducto == -1) return;

            Producto? producto = D_Productos.BuscarPorId(idProducto);
            if (producto != null)
            {
                dgvProductos.CurrentRow.Cells["IdProducto"].Value = idProducto;
                int rowIndex = dgvProductos.CurrentRow.Index;
                AgregarProductoAlGrid(rowIndex, producto);
            }

            CalcularSubtotal(dgvProductos.CurrentRow.Index);
            CalcularTotal();
            // Agregar fila al final
            dgvProductos.NotifyCurrentCellDirty(true);
        }

        public void AgregarProductoAlGrid(int rowIndex, Producto producto)
        {
            dgvProductos.Rows[rowIndex].Cells["StockActual"].Value = producto.Stock;
            dgvProductos.Rows[rowIndex].Cells["Nombre"].Value = producto.Nombre;
            dgvProductos.Rows[rowIndex].Cells["Marca"].Value = producto.Marca.Nombre;
            dgvProductos.Rows[rowIndex].Cells["PrecioCompra"].Value = producto.PrecioCompra;
            dgvProductos.Rows[rowIndex].Cells["PrecioVenta"].Value = producto.PrecioVenta;
            dgvProductos.Rows[rowIndex].Cells["Cantidad"].Value = 1;
        }

        private decimal CalcularSubtotal(int rowIndex)
        {
            // Verificar si el valor de la celda "Precio" no es nulo
            object precioObj = dgvProductos.Rows[rowIndex].Cells["PrecioCompra"].Value;
            if (precioObj != null && decimal.TryParse(precioObj.ToString(), out decimal precio))
            {
                // Verificar si el valor de la celda "Cantidad" no es nulo
                object cantidadObj = dgvProductos.Rows[rowIndex].Cells["Cantidad"].Value;
                if (cantidadObj != null && int.TryParse(cantidadObj.ToString(), out int cantidad))
                {
                    decimal subtotal = precio * cantidad;
                    dgvProductos.Rows[rowIndex].Cells["Subtotal"].Value = subtotal;
                    return subtotal;
                }
            }

            return 0;
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                //decimal subtotal = CalcularSubtotal(row.Index);
                decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                total += subtotal;
            }

            lblTotal.Text = total.ToString();
            return total;
        }

        public void LimpiarTabla()
        {
            lblTotal.Text = "0.00";
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
        }

        private void EliminarFilasVacias()
        {
            // Terminar cualquier edición en curso en el DataGridView
            if (dgvProductos.IsCurrentCellInEditMode) dgvProductos.EndEdit();

            // Obtener el índice de la columna "IdProducto"
            int columnaIdProducto = dgvProductos.Columns["IdProducto"].Index;

            // Recorrer las filas en orden inverso para evitar problemas al eliminar filas
            for (int i = dgvProductos.Rows.Count - 1; i >= 0; i--)
            {
                // Saltar la nueva fila sin confirmar
                if (dgvProductos.Rows[i].IsNewRow) continue;

                // Verificar si la celda de la columna "IdProducto" está vacía
                if (dgvProductos.Rows[i].Cells[columnaIdProducto].Value == null ||
                    string.IsNullOrWhiteSpace(dgvProductos.Rows[i].Cells[columnaIdProducto].Value.ToString()))
                {
                    dgvProductos.Rows.RemoveAt(i);
                }
            }

            // Cancelar cualquier edición en curso para la fila nueva después de la eliminación
            dgvProductos.CancelEdit();
        }
        #endregion
    }
}
