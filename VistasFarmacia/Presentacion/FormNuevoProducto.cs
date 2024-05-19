
using Farmacia.Datos;
using Farmacia.Presentacion;
using System.Globalization;
using VistasFarmacia.Entidad;

namespace VistasFarmacia.Forms
{
    public partial class FormNuevoProducto : Form
    {

        private readonly Producto _producto;
        int idProducto = 0;
        string proveedor;

        public FormNuevoProducto(Producto producto)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            _producto = producto;

            idProducto = producto.IdProducto;
            txtNombre.Text = _producto.Nombre ?? "";
            txtPrecioCompra.Text = _producto.PrecioCompra.ToString() ?? "";
            txtPrecioVenta.Text = _producto.PrecioVenta.ToString() ?? "";
            txtStock.Text = _producto.Stock.ToString() ?? "";

            if (idProducto != 0)
            {
                lblTitulo.Text = "Actualizar Producto";
                btnGuardar.Text = "Actualizar Producto";
            }

            proveedor = producto.ObjProveedor?.Nombre?.ToString() ?? "NA";
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ListarProveedores();

            // Buscar el índice del proveedor 
            int index = cmbProveedor.FindStringExact(proveedor);
            // Verificar si se encontró el proveedor
            if (index != -1)
            {
                // Seleccionar el proveedor en el ComboBox
                cmbProveedor.SelectedIndex = index;
            }
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
            lblTitulo.ForeColor = ThemeColor.SecondaryColor;
            labelProveedor.ForeColor = ThemeColor.SecondaryColor;
            labelNombre.ForeColor = ThemeColor.SecondaryColor;
            labelPrecioCompra.ForeColor = ThemeColor.SecondaryColor;
            labelPrecioVenta.ForeColor = ThemeColor.SecondaryColor;
            labelStock.ForeColor = ThemeColor.SecondaryColor;
        }

        #region "Datos"
        D_Productos Productos = new();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los cuadros de texto
            string inputCompra = txtPrecioCompra.Text;
            string inputVenta = txtPrecioVenta.Text;

            // Reemplaza la coma por un punto si está presente
            inputCompra = inputCompra.Replace(',', '.');
            inputVenta = inputVenta.Replace(',', '.');

            // Parsear los valores
            decimal precioCompra;
            decimal precioVenta;

            try
            {
                // Aanalizar los valores
                precioCompra = decimal.Parse(inputCompra, CultureInfo.InvariantCulture);
                precioVenta = decimal.Parse(inputVenta, CultureInfo.InvariantCulture);

                // Nuevo
                if (idProducto == 0)
                {
                    D_Productos.Crear(
                    Convert.ToInt32(cmbProveedor.SelectedValue),
                    txtNombre.Text,
                    precioCompra,
                    precioVenta,
                    Convert.ToInt32(txtStock.Text)
                    );
                }

                // Editar
                if (idProducto != 0)
                {
                    D_Productos.Editar(
                        idProducto,
                        Convert.ToInt32(cmbProveedor.SelectedValue),
                        txtNombre.Text,
                        precioCompra,
                        precioVenta,
                        Convert.ToInt32(txtStock.Text)
                    );
                }

                LimpiarCampos();
                MessageBox.Show("Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear o actualizar producto." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Helpers"
        public void ListarProveedores()
        {
            D_Proveedores Datos = new D_Proveedores();

            try
            {
                cmbProveedor.DataSource = D_Proveedores.Listar();
                cmbProveedor.ValueMember = "id_proveedor";
                cmbProveedor.DisplayMember = "proveedor";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los proveedores." + ex.Message + ex.StackTrace, "Error al mostrar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            idProducto = 0;
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
        }

        #endregion
    }
}
