﻿
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;
using Farmacia.Presentacion.Reportes;
using Farmacia.Presentacion.Reportes.QuestPDF;
using QuestPDF.Fluent;

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
            DateTime fechaInicio = DateTime.MinValue.Date;
            DateTime fechaFin = DateTime.Now.Date;
            MostrarVentas(fechaInicio, fechaFin);
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button) && btns.Name != "btnEliminar")
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

        #region Botones
        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportesClosedXML reportes = new();
            reportes.Excel("Ventas", dgvVentas);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ninguna venta seleccionada");
                return;
            }

            int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["IdVenta"].Value);
            var venta = D_Ventas.VentaPorId(idVenta);
            var document = new ReporteUnaVenta(venta!);

            // Mostrar sin guardar
            //document.GeneratePdfAndShow();

            string fechaHoraConversion = DateTime.Now.ToString("dd-MM-yyyy__HH-mm-ss");
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{fechaHoraConversion}.pdf");

            // Generar PDF y guardar en la ruta especificada
            document.GeneratePdf(filePath);

            MessageBox.Show("Guardado en el escritorio.");
        }

        private void btnPDFReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpDesde.Value.Date;
            DateTime fechaFin = dtpHasta.Value.Date;
            var ventas = D_Ventas.VentasPorFechas(fechaInicio, fechaFin);
            var document = new ReporteVariasVentas(ventas, fechaInicio, fechaFin);

            // Mostrar sin guardar
            //document.GeneratePdfAndShow();

            string fechaHoraConversion = DateTime.Now.ToString("dd-MM-yyyy__HH-mm-ss");
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{fechaHoraConversion}.pdf");

            // Generar PDF y guardar en la ruta especificada
            document.GeneratePdf(filePath);

            MessageBox.Show("Guardado en el escritorio.");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpDesde.Value.Date;
            DateTime fechaFin = dtpHasta.Value.Date;
            MostrarVentas(fechaInicio, fechaFin);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.MinValue.Date;
            DateTime fechaFin = DateTime.Now.Date;
            MostrarVentas(fechaInicio, fechaFin);
        }
        #endregion

        public void MostrarVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Venta> todasVentas = D_Ventas.VentasPorFechas(fechaInicio, fechaFin);

            decimal totalVentas = 0;
            decimal totalGanancias = 0;

            dgvVentas.Rows.Clear();

            foreach (var venta in todasVentas)
            {
                List<Producto> productosVenta = venta.Productos!;

                // Total Venta
                decimal totalVenta = productosVenta.Sum(producto => producto.PrecioVenta * producto.Stock);

                // Ganancias de la venta
                decimal totalGananciasVenta = productosVenta.Sum(producto => (producto.PrecioVenta - producto.PrecioCompra) * producto.Stock);

                // PARA ETIQUETAS GLOBALES CON PROPOSITOS INFORMATIVOS
                totalVentas += totalVenta; // Sumar al total de ventas
                totalGanancias += totalGananciasVenta; // Sumar al total de ganancias

                // Encabezado de cada venta dentro de la tabla
                int rowIndex = dgvVentas.Rows.Add(
                    venta.IdVenta,
                    $"VENTA #{venta.IdVenta}",
                    $"CLIENTE: {venta.Cliente.Nombre}",
                    "FECHA",
                    venta.Fecha.ToString("dd/MM/yyyy"),
                    "TOTAL",
                    totalVenta
                 );
                dgvVentas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                dgvVentas.Rows[rowIndex].Height = 50;

                foreach (var producto in productosVenta)
                {
                    dgvVentas.Rows.Add(
                        venta.IdVenta,
                        producto.IdProducto,
                        producto.Nombre,
                        producto.Stock,
                        producto.PrecioCompra,
                        producto.PrecioVenta,
                        producto.PrecioVenta * producto.Stock
                    );
                }
            }

            lblVentas.Text = totalVentas.ToString();
            lblGanancias.Text = totalGanancias.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ningun registro seleccionado");
            };

            DialogResult resultado = MessageBox.Show("Borrar la venta " + dgvVentas.CurrentRow.Cells["IdVenta"].Value, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            D_Ventas.Eliminar(Convert.ToInt32(dgvVentas.CurrentRow.Cells["IdVenta"].Value));

            DateTime fechaInicio = DateTime.MinValue.Date;
            DateTime fechaFin = DateTime.Now.Date;
            MostrarVentas(fechaInicio, fechaFin);
        }
    }
}
