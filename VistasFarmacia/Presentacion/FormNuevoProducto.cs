﻿
using Farmacia.Datos;
using Farmacia.Presentacion;
using System.Globalization;

namespace VistasFarmacia.Forms
{
    public partial class FormNuevoProducto : Form
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
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
            labelIngresoProductos.ForeColor = ThemeColor.SecondaryColor;
            labelProveedor.ForeColor = ThemeColor.SecondaryColor;
            labelNombre.ForeColor = ThemeColor.SecondaryColor;
            labelPrecioCompra.ForeColor = ThemeColor.SecondaryColor;
            labelPrecioVenta.ForeColor = ThemeColor.SecondaryColor;
            labelStock.ForeColor = ThemeColor.SecondaryColor;
        }

        #region "Datos"
        D_Productos Productos = new D_Productos();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Convertir numeros a decimales al utilizar punto, ej, 10.50
            // Por defecto convierte utilizando comas, ej, 10,5
            decimal precioCompra;
            decimal precioVenta;

            decimal.TryParse(txtPrecioCompra.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out precioCompra);
            decimal.TryParse(txtPrecioVenta.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out precioVenta);

            try
            {
                Productos.Crear(
                    Convert.ToInt32(cmbProveedor.SelectedValue),
                    txtNombre.Text,
                    precioCompra,
                    precioVenta,
                    Convert.ToInt32(txtStock.Text)
                    );

                LimpiarCampos();
                MessageBox.Show("Nuevo producto agregado correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear producto." + ex.Message + ex.StackTrace, "Error al crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Helpers"
        public void ListarProveedores()
        {
            D_Proveedores Datos = new D_Proveedores();

            try
            {
                cmbProveedor.DataSource = Datos.Listar();
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
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
        }
        #endregion
    }
}