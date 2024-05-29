
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;
using System.Data;

namespace VistasFarmacia.Forms
{
    public partial class FormNuevaVenta : Form
    {
        public FormNuevaVenta()
        {
            InitializeComponent();
        }

        private void FormIngresoVentas_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ListarClientes();
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
            lblCliente.ForeColor = ThemeColor.SecondaryColor;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvProductos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            lblTotalTitulo.BackColor = ThemeColor.SecondaryColor;
        }

        #region Datos
        public void ListarClientes()
        {
            try
            {
                D_Clientes clientes = new();
                cmbClientes.DataSource = D_Clientes.Listar();
                cmbClientes.ValueMember = "IdCliente";
                cmbClientes.DisplayMember = "NombreNit";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion

        #region Botones

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar tabla vacia
            if (dgvProductos.RowCount <= 1)
            {
                MessageBox.Show("Ningun producto agregado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            // Verificar cliente seleccionado
            if (Convert.ToInt32(cmbClientes.SelectedValue) < 1)
            {
                MessageBox.Show("Ningun cliente seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            // Guardar venta
            try
            {
                int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                int idVenta = D_Ventas.CrearVenta(idCliente);
                D_Ventas.InsertarDetalleVenta(idVenta, dgvProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar venta " + ex.Message, "Error al guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();

            MessageBox.Show("Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "0.00";
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
        }

        #endregion

        #region Helpers

        // ============================================================================================
        // REACCIONAR A CAMBIOS EN LA TABLA ===========================================================
        // ============================================================================================
        private void dgvNuevaVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Buscar producto si se ingresa el codigo en la columna ==================================
            if (dgvProductos.Columns[e.ColumnIndex].Name == "IdProducto")
            {
                // Obtener codigo del producto ingresado o verificar si existe el producto
                if (!int.TryParse(Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), out int codigoProducto) ||
                    D_Productos.BuscarPorId(codigoProducto) is not Producto producto)
                {
                    MessageBox.Show("No se encontró el producto con el código ingresado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if(dgvProductos.Rows.Count > 0) dgvProductos.Rows.RemoveAt(e.RowIndex);
                    CalcularTotal();
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
                    //if (dgvProductos.Columns[e.ColumnIndex].Name == "Producto") return;
                    dgvProductos.Rows.RemoveAt(e.RowIndex);
                }
            }

            VerificarCantidadYCalcularSubtotal(e.RowIndex);
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
            
            VerificarCantidadYCalcularSubtotal(dgvProductos.CurrentRow.Index);
            CalcularTotal();
            // Agregar fila al final
            dgvProductos.NotifyCurrentCellDirty(true);
        }

        private void AgregarProductoAlGrid(int rowIndex, Producto producto)
        {
            dgvProductos.Rows[rowIndex].Cells["Cantidad"].Value = 1;
            dgvProductos.Rows[rowIndex].Cells["Stock"].Value = producto.Stock;
            dgvProductos.Rows[rowIndex].Cells["Producto"].Value = producto.Nombre;
            dgvProductos.Rows[rowIndex].Cells["Marca"].Value = producto.Marca.Nombre;
            dgvProductos.Rows[rowIndex].Cells["PrecioCompra"].Value = producto.PrecioCompra;
            dgvProductos.Rows[rowIndex].Cells["PrecioVenta"].Value = producto.PrecioVenta;
        }

        private bool VerificarCantidadYCalcularSubtotal(int rowIndex)
        {
            // Verificar si el valor de la celda "Stock" no es nulo
            object stockObj = dgvProductos.Rows[rowIndex].Cells["Stock"].Value;
            if (stockObj != null && int.TryParse(stockObj.ToString(), out int stock))
            {
                // Verificar si el valor de la celda "Cantidad" no es nulo
                object cantidadObj = dgvProductos.Rows[rowIndex].Cells["Cantidad"].Value;
                if (cantidadObj != null && int.TryParse(cantidadObj.ToString(), out int cantidad))
                {
                    if (cantidad > stock)
                    {
                        MessageBox.Show("La cantidad no puede ser mayor al stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvProductos.Rows[rowIndex].Cells["Cantidad"].Value = 1;
                    }

                    CalcularSubtotal(rowIndex);
                }
            }

            return false;
        }

        private void CalcularSubtotal(int rowIndex)
        {
            // Verificar si el valor de la celda "Precio" no es nulo
            object precioObj = dgvProductos.Rows[rowIndex].Cells["PrecioVenta"].Value;
            if (precioObj != null && decimal.TryParse(precioObj.ToString(), out decimal precio))
            {
                // Verificar si el valor de la celda "Cantidad" no es nulo
                object cantidadObj = dgvProductos.Rows[rowIndex].Cells["Cantidad"].Value;
                if (cantidadObj != null && int.TryParse(cantidadObj.ToString(), out int cantidad))
                {
                    decimal subtotal = precio * cantidad;
                    dgvProductos.Rows[rowIndex].Cells["Subtotal"].Value = subtotal;
                }
            }
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                total += subtotal;
            }

            lblTotal.Text = total.ToString();
            return total;
        }

        #endregion
    }
}
