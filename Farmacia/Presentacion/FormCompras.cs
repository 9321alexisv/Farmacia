﻿
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;
using Farmacia.Presentacion.Reportes;

namespace VistasFarmacia.Forms
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
            MostrarHistorialVentas();
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
            labelTablaCompras.ForeColor = ThemeColor.SecondaryColor;
            dgvCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCompras.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dgvCompras.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCompras.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            panel2.BackColor = ThemeColor.SecondaryColor;
        }

        #region Datos
        public void MostrarHistorialVentas()
        {
            D_Compras compras = new();
            List<Compra> todasCompras = D_Compras.ObtenerCompras();

            decimal totalCompras = 0;

            dgvCompras.Rows.Clear();

            foreach (var compra in todasCompras)
            {
                List<DetalleCompra> detallesCompra = D_Compras.ObtenerDetallesCompra(compra.IdCompra);

                // PARA ETIQUETAS GLOBALES CON PROPOSITOS INFORMATIVOS
                decimal totalCompra = detallesCompra.Sum(detalle => detalle.PrecioCompra * detalle.Cantidad);
                totalCompras += totalCompra; // Sumar al total de compra

                // Encabezado de cada venta dentro de la tabla
                int rowIndex = dgvCompras.Rows.Add(
                    $"COMPRA #{compra.IdCompra}",
                    $"FECHA: {compra.Fecha}",
                    "PROVEEDOR:",
                    compra.Proveedor.Nombre,
                    "TOTAL",
                    totalCompra
                 );
                dgvCompras.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                dgvCompras.Rows[rowIndex].Height = 50;

                foreach (var detalle in detallesCompra)
                {
                    dgvCompras.Rows.Add(
                        detalle.Producto.IdProducto,
                        detalle.Producto.Marca.Nombre,
                        detalle.Producto.Nombre,
                        detalle.Cantidad,
                        detalle.PrecioCompra,
                        detalle.PrecioCompra * detalle.Cantidad
                    );
                }
            }

            lblCompras.Text = totalCompras.ToString();
        }

        private void FiltrarDatos()
        {
            // Obtener los valores de los DateTimePicker en formato DateTime
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

            // Convertir a cadena de formato corto
            string fechaInicioStr = fechaInicio.ToString("d/M/yyyy");
            string fechaFinStr = fechaFin.ToString("d/M/yyyy");

            D_Compras compras = new();
            List<Compra> todasCompras = D_Compras.ObtenerComprasPorFechas(fechaInicio, fechaFin);

            decimal totalCompras = 0;

            dgvCompras.Rows.Clear();

            foreach (var compra in todasCompras)
            {
                List<DetalleCompra> detallesCompra = D_Compras.ObtenerDetallesCompra(compra.IdCompra);

                // PARA ETIQUETAS GLOBALES CON PROPOSITOS INFORMATIVOS
                decimal totalCompra = detallesCompra.Sum(detalle => detalle.PrecioCompra * detalle.Cantidad);
                totalCompras += totalCompra; // Sumar al total de compra

                // Encabezado de cada venta dentro de la tabla
                int rowIndex = dgvCompras.Rows.Add(
                    $"COMPRA #{compra.IdCompra}",
                    $"FECHA: {compra.Fecha}",
                    "TOTAL",
                    totalCompra
                 );
                dgvCompras.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                dgvCompras.Rows[rowIndex].Height = 50;

                foreach (var detalle in detallesCompra)
                {
                    dgvCompras.Rows.Add(
                        detalle.Producto,
                        detalle.Cantidad,
                        detalle.PrecioCompra,
                        detalle.PrecioCompra * detalle.Cantidad
                    );
                }
            }

            lblCompras.Text = totalCompras.ToString();
        }
        #endregion

        #region Botones

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportesClosedXML reportes = new();
            reportes.Excel("Compras", dgvCompras);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                FiltrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            MostrarHistorialVentas();
        }

        #endregion
    }
}
