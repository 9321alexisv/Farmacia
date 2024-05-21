
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;

namespace VistasFarmacia.Forms
{
    public partial class FormNuevaCompras : Form
    {
        public FormNuevaCompras()
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
            labelTablaIngresoCompras.ForeColor = ThemeColor.SecondaryColor;
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
            if (dgvProductos.RowCount <= 1)
            {
                MessageBox.Show("Ningun producto agregado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idProveedor = Convert.ToInt32(cmbProveedores.SelectedValue);

            try
            {
                int idCompra = D_Compras.CrearCompra(idProveedor);
                D_Compras.InsertarDetalleCompra(idCompra, dgvProductos);
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
            // BUSCAR PRODUCTO ========================================================================
            // Verifica que la celda editada esté en la columna "IdProducto"
            if (dgvProductos.Columns[e.ColumnIndex].Name == "IdProducto")
            {
                // Obtén el código del producto ingresado
                if (int.TryParse(dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int codigoProducto))
                {
                    // Busca el producto 
                    Producto? producto = D_Productos.BuscarPorId(codigoProducto);

                    if (producto == null)
                    {
                        MessageBox.Show("No se encontró el producto con el código ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        dgvProductos.Rows.RemoveAt(e.RowIndex);
                        return;
                    }

                    // Carga los datos del producto en la fila correspondiente
                    dgvProductos.Rows[e.RowIndex].Cells["StockActual"].Value = producto.Stock;
                    dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value = producto.Nombre;
                    dgvProductos.Rows[e.RowIndex].Cells["Marca"].Value = producto.Marca.Nombre;
                    dgvProductos.Rows[e.RowIndex].Cells["PrecioCompra"].Value = producto.PrecioCompra;
                    dgvProductos.Rows[e.RowIndex].Cells["PrecioVenta"].Value = producto.PrecioVenta;
                    dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;
                }
            }

            // CALCULAR SUBTOTAL =====================================================================
            decimal subtotal = CalcularSubtotal(e.RowIndex);
            dgvProductos.Rows[e.RowIndex].Cells["Subtotal"].Value = subtotal;

            // CALCULAR TOTAL ========================================================================
            decimal total = CalcularTotal();
            lblTotal.Text = total.ToString();
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
                    return precio * cantidad;
                }
            }

            return 0;
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                decimal subtotal = CalcularSubtotal(row.Index);
                total += subtotal;
            }

            return total;
        }

        public void LimpiarTabla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
        }

        #endregion
    }
}
