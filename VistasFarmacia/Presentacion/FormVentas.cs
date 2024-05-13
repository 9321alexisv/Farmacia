﻿
using Farmacia.Datos;
using Farmacia.Presentacion;
using VistasFarmacia.Entidad;

namespace VistasFarmacia.Forms
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            LoadTheme();
            try
            {
                MostrarHistorialVentas();
            }
            catch (Exception ex)
            {

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
            labelTablaVentas.ForeColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.SecondaryColor;
            dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvVentas.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVentas.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;

        }

        public void MostrarHistorialVentas()
        {
            D_Ventas ventas = new D_Ventas();
            List<Venta> todasVentas = ventas.ObtenerVentas();

            decimal totalVentas = 0;
            decimal totalGanancias = 0;

            dgvVentas.Rows.Clear();

            foreach (var venta in todasVentas)
            {
                List<DetalleVenta> detallesVenta = ventas.ObtenerDetallesVenta(venta.IdVenta);

                // Total Venta
                decimal totalVenta = detallesVenta.Sum(detalle => detalle.PrecioVenta * detalle.Cantidad);

                // Ganancias de la venta
                decimal totalGananciasVenta = detallesVenta.Sum(detalle => (detalle.PrecioVenta - detalle.PrecioCompra) * detalle.Cantidad);

                // PARA ETIQUETAS GLOBALES CON PROPOSITOS INFORMATIVOS
                totalVentas += totalVenta; // Sumar al total de ventas
                totalGanancias += totalGananciasVenta; // Sumar al total de ganancias

                // Encabezado de cada venta dentro de la tabla
                int rowIndex = dgvVentas.Rows.Add(
                    $"VENTA #{venta.IdVenta}",
                    $"CLIENTE: {venta.Cliente}",
                    $"FECHA: {venta.Fecha}",
                    "",
                    "",
                    $"TOTAL: {totalVenta}"
                 );
                dgvVentas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                dgvVentas.Rows[rowIndex].Height = 50;

                foreach (var detalle in detallesVenta)
                {
                    dgvVentas.Rows.Add(
                        detalle.IdProducto,
                        detalle.Producto,
                        detalle.Cantidad,
                        detalle.PrecioCompra,
                        detalle.PrecioVenta,
                        detalle.PrecioVenta * detalle.Cantidad
                    );
                }
            }

            lblVentas.Text = totalVentas.ToString();
            lblGanancias.Text = totalGanancias.ToString();
        }
    }
}
