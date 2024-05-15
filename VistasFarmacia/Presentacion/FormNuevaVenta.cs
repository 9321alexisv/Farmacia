
using Farmacia.Datos;
using Farmacia.Presentacion;
using VistasFarmacia.Datos;
using VistasFarmacia.Entidad;

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
            dgvNuevaVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNuevaVenta.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvNuevaVenta.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNuevaVenta.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            panel2.BackColor = ThemeColor.SecondaryColor;
        }

        // Mostrar clientes
        public void ListarClientes()
        {
            try
            {
                D_Clientes clientes = new();
                cmbClientes.DataSource = clientes.Listar();
                cmbClientes.ValueMember = "id_cliente";
                cmbClientes.DisplayMember = "nit";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                D_Ventas ventas = new D_Ventas();

                int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                int idVenta = ventas.CrearVenta(idCliente);
                ventas.ActualizarStockProductos(idVenta, dgvNuevaVenta);
                ventas.InsertarDetalleVenta(idVenta, dgvNuevaVenta);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al guardar venta " + ex.Message, "Error al guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvNuevaVenta.DataSource = null;
            dgvNuevaVenta.Rows.Clear();

            MessageBox.Show("Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============================================================================================
        // REACCIONAR A CAMBIOS EN LA TABLA ===========================================================
        // ============================================================================================
        private void dgvNuevaVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // BUSCAR PRODUCTO ======================================================================== 
            if (dgvNuevaVenta.Columns[e.ColumnIndex].Name == "Codigo")
            {
                int codigoProducto;
                if (int.TryParse(dgvNuevaVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out codigoProducto))
                {
                    D_Productos productos = new D_Productos();
                    Producto producto = productos.BuscarPorId(codigoProducto);
                    if (producto != null)
                    {
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["Producto"].Value = producto.Nombre;
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["Stock"].Value = producto.Stock;
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["Precio"].Value = producto.PrecioVenta;
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["PrecioCompra"].Value = producto.PrecioCompra;
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto con el código ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // CALCULAR SUBTOTAL =====================================================================
            decimal subtotal = CalcularSubtotal(e.RowIndex);
            dgvNuevaVenta.Rows[e.RowIndex].Cells["Subtotal"].Value = subtotal;

            // CALCULAR TOTAL ========================================================================
            decimal total = CalcularTotal();
            lblTotal.Text = total.ToString();
        }

        private decimal CalcularSubtotal(int rowIndex)
        {
            decimal precio = 0;
            int cantidad = 0;

            // Verificar si el valor de la celda "Precio" no es nulo
            object precioObj = dgvNuevaVenta.Rows[rowIndex].Cells["Precio"].Value;
            if (precioObj != null && decimal.TryParse(precioObj.ToString(), out precio))
            {
                // Verificar si el valor de la celda "Cantidad" no es nulo
                object cantidadObj = dgvNuevaVenta.Rows[rowIndex].Cells["Cantidad"].Value;
                if (cantidadObj != null && int.TryParse(cantidadObj.ToString(), out cantidad))
                {
                    return precio * cantidad;
                }
            }

            return 0;
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvNuevaVenta.Rows)
            {
                decimal subtotal = CalcularSubtotal(row.Index);
                total += subtotal;
            }

            return total;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "0.00";
            dgvNuevaVenta.DataSource = null;
            dgvNuevaVenta.Rows.Clear();
        }
    }
}
