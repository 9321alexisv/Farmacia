
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
                ventas.InsertarDetalleVenta(idVenta, dgvNuevaVenta);

                //dgvNuevaVenta.DataSource = null;
                //dgvNuevaVenta.Rows.Clear();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al guardar venta " + ex.Message, "Error al guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================================================
        // REACCIONAR A CAMBIOS EN LA TABLA ===========================================================
        // ============================================================================================
        private void dgvNuevaVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // BUSCAR PRODUCTO ========================================================================
            // Verifica que la celda editada esté en la columna "codigo"
            if (dgvNuevaVenta.Columns[e.ColumnIndex].Name == "Codigo")
            {
                int codigoProducto; // Obtén el código del producto ingresado

                if (int.TryParse(dgvNuevaVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out codigoProducto))
                {
                    // Busca el producto 
                    D_Productos productos = new D_Productos();
                    Producto producto = productos.BuscarPorId(codigoProducto);

                    if (producto != null)
                    {
                        // Carga los datos del producto en la fila correspondiente
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["Producto"].Value = producto.Nombre;
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["Precio"].Value = producto.PrecioVenta;
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["PrecioCompra"].Value = producto.PrecioCompra;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto con el código ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // CALCULAR SUBTOTAL =====================================================================
            // Calcular subtotal de producto despues de ingresar la cantidad

            // Verifica que la celda modificada esté en la columna "Cantidad"
            if (dgvNuevaVenta.Columns[e.ColumnIndex].Name == "cantidad")
            {
                // Obtén el valor de la cantidad ingresada
                decimal cantidad;
                if (decimal.TryParse(dgvNuevaVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out cantidad))
                {
                    // Busca el precio en la columna correspondiente
                    decimal precio;
                    if (decimal.TryParse(dgvNuevaVenta.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out precio))
                    {
                        // Calcula el subtotal
                        decimal subtotal = cantidad * precio;

                        // Asigna el subtotal a la celda correspondiente
                        dgvNuevaVenta.Rows[e.RowIndex].Cells["Subtotal"].Value = subtotal;
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvNuevaVenta.DataSource = null;
            dgvNuevaVenta.Rows.Clear();
        }
    }
}
