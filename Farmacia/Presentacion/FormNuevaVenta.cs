
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;

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
            labelTablaIngresoVentas.ForeColor = ThemeColor.SecondaryColor;
            lblCliente.ForeColor = ThemeColor.SecondaryColor;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvProductos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            panel2.BackColor = ThemeColor.SecondaryColor;
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
            // BUSCAR PRODUCTO ======================================================================== 
            if (dgvProductos.Columns[e.ColumnIndex].Name == "IdProducto")
            {
                // Obtener codigo del producto ingresado
                if (int.TryParse(dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int codigoProducto))
                {
                    Producto? producto = D_Productos.BuscarPorId(codigoProducto);
                    if (producto != null)
                    {
                        dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;
                        dgvProductos.Rows[e.RowIndex].Cells["Stock"].Value = producto.Stock;
                        dgvProductos.Rows[e.RowIndex].Cells["Producto"].Value = producto.Nombre;
                        dgvProductos.Rows[e.RowIndex].Cells["Marca"].Value = producto.Marca.Nombre;
                        dgvProductos.Rows[e.RowIndex].Cells["PrecioCompra"].Value = producto.PrecioCompra;
                        dgvProductos.Rows[e.RowIndex].Cells["PrecioVenta"].Value = producto.PrecioVenta;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto con el código ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvProductos.Rows.RemoveAt(e.RowIndex);

                        return;
                    }
                }
            }

            // Validar que no se ingrese Cantidad cuando no hay un producto
            if (dgvProductos.Rows[e.RowIndex].Cells["IdProducto"].Value == null)
            {
                MessageBox.Show("No se ha ingresado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvProductos.Rows.RemoveAt(e.RowIndex);
            }

            // CALCULAR SUBTOTAL =====================================================================
            VerificarCantidadYCalcularSubtotal(e.RowIndex);

            // CALCULAR TOTAL ========================================================================
            decimal total = CalcularTotal();
            lblTotal.Text = total.ToString();
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

            return total;
        }

        #endregion
    }
}
