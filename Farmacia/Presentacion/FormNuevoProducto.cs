
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;
using System.Globalization;

namespace VistasFarmacia.Forms
{
    public partial class FormNuevoProducto : Form
    {
        readonly Producto? _producto;

        public FormNuevoProducto(Producto? producto)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            if (producto != null)
            {
                _producto = producto;
                lblTitulo.Text = "Actualizar Producto";
                btnGuardar.Text = "Actualizar Producto";
            }
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ListarMarcas();
            if (_producto != null) LlenarCampos(_producto);
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
            lblMarca.ForeColor = ThemeColor.SecondaryColor;
            labelNombre.ForeColor = ThemeColor.SecondaryColor;
            labelPrecioCompra.ForeColor = ThemeColor.SecondaryColor;
            labelPrecioVenta.ForeColor = ThemeColor.SecondaryColor;
            labelStock.ForeColor = ThemeColor.SecondaryColor;
            lblStockMinimo.ForeColor = ThemeColor.SecondaryColor;
        }

        #region "Datos"
        int idProducto = 0;

        public void ListarMarcas()
        {
            try
            {
                cmbMarca.DataSource = D_Marcas.Listar();
                cmbMarca.ValueMember = "IdMarca";
                cmbMarca.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las marcas." + ex.Message, "Error al mostrar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Length == 0 || txtPrecioCompra.TextLength == 0  || txtPrecioVenta.TextLength == 0 
                || txtStock.TextLength == 0 || txtStockMinimo.TextLength == 0 ) { 
                
                MessageBox.Show("Todos los campos son obligatorios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

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

                Marca marca = new()
                {
                    IdMarca = Convert.ToInt32(cmbMarca.SelectedValue),
                    Nombre = cmbMarca.SelectedText
                };

                Producto producto = new()
                {
                    IdProducto = idProducto,
                    Marca = marca,
                    Nombre = txtNombre.Text,
                    PrecioCompra = precioCompra,
                    PrecioVenta = precioVenta,
                    Stock = Convert.ToInt32(txtStock.Text),
                    StockMinimo = Convert.ToInt32(txtStockMinimo.Text),
                };

                // Nuevo
                if (idProducto == 0) D_Productos.Crear(producto);

                // Actualizar
                if(idProducto != 0) D_Productos.Editar(producto);

                LimpiarCampos();
                MessageBox.Show("Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion

        #region Helpers

        public void LimpiarCampos()
        {
            idProducto = 0;
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
        }

        public void LlenarCampos(Producto producto)
        {
            idProducto = producto.IdProducto;
            txtNombre.Text = producto.Nombre;
            txtPrecioCompra.Text = Convert.ToString(producto.PrecioCompra);
            txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
            txtStock.Text = Convert.ToString(producto.Stock);
            txtStockMinimo.Text = Convert.ToString(producto.StockMinimo);

            // Buscar el índice de la marca
            string marca = producto.Marca.Nombre ?? "";
            int index = cmbMarca.FindStringExact(marca);
            // Verificar si se encontro y preseleccionar 
            if (index != -1) cmbMarca.SelectedIndex = index;
        }
        #endregion
    }
}
