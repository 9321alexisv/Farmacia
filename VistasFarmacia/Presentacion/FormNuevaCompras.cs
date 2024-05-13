
using Farmacia.Datos;
using Farmacia.Presentacion;
using VistasFarmacia.Datos;
using VistasFarmacia.Entidad;

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

        public void ListarProveedores()
        {
            try
            {
                D_Proveedores proveedores = new();
                cmbProveedores.DataSource = proveedores.Listar();
                cmbProveedores.ValueMember = "id_proveedor";
                cmbProveedores.DisplayMember = "proveedor";
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
                D_Compras compras = new();

                int idCompra = compras.CrearCompra();
                compras.InsertarDetalleCompra(idCompra, dgvProductos);

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al guardar venta " + ex.Message, "Error al guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarTabla();
            }
        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // BUSCAR PRODUCTO ========================================================================
            // Verifica que la celda editada esté en la columna "codigo"
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Codigo")
            {
                int codigoProducto; // Obtén el código del producto ingresado

                if (int.TryParse(dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out codigoProducto))
                {
                    // Busca el producto 
                    D_Productos productos = new D_Productos();
                    Producto producto = productos.BuscarPorId(codigoProducto);

                    if (producto != null)
                    {
                        // Carga los datos del producto en la fila correspondiente
                        dgvProductos.Rows[e.RowIndex].Cells["Producto"].Value = producto.Nombre;
                        dgvProductos.Rows[e.RowIndex].Cells["PrecioCompra"].Value = producto.PrecioCompra;
                        dgvProductos.Rows[e.RowIndex].Cells["PrecioVenta"].Value = producto.PrecioVenta;
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
            if (dgvProductos.Columns[e.ColumnIndex].Name == "cantidad")
            {
                // Obtén el valor de la cantidad ingresada
                decimal cantidad;
                if (decimal.TryParse(dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out cantidad))
                {
                    // Busca el precio en la columna correspondiente
                    decimal precio;
                    if (decimal.TryParse(dgvProductos.Rows[e.RowIndex].Cells["PrecioCompra"].Value.ToString(), out precio))
                    {
                        // Calcula el subtotal
                        decimal subtotal = cantidad * precio;

                        // Asigna el subtotal a la celda correspondiente
                        dgvProductos.Rows[e.RowIndex].Cells["Subtotal"].Value = subtotal;
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
        }

        public void LimpiarTabla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
        }
    }
}
