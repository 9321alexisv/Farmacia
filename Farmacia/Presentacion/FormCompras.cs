
using Farmacia.Datos;
using Farmacia.Entidad;
using Farmacia.Presentacion;
using Farmacia.Presentacion.Reportes;
using Farmacia.Presentacion.Reportes.QuestPDF;
using QuestPDF.Fluent;

namespace VistasFarmacia.Forms
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        #region Load
        private void FormCompras_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
            MostrarCompras();
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

        #endregion

        #region Datos
        public void MostrarCompras(DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            // Si fechaInicio o fechaFin son nulos, asignar valores predeterminados
            DateTime inicio = fechaInicio ?? DateTime.MinValue.Date;
            DateTime fin = fechaFin ?? DateTime.Now.Date;

            List<Compra> compras = D_Compras.ComprasPorFechas(inicio, fin);

            decimal totalCompras = 0;

            dgvCompras.Rows.Clear();

            foreach (var compra in compras)
            {
                List<Producto> detallesCompra = compra.Productos!;

                // PARA ETIQUETAS GLOBALES CON PROPOSITOS INFORMATIVOS
                decimal totalCompra = detallesCompra.Sum(detalle => detalle.PrecioCompra * detalle.Stock);
                totalCompras += totalCompra; // Sumar al total de compra

                // Encabezado de cada venta dentro de la tabla
                int rowIndex = dgvCompras.Rows.Add(
                    compra.IdCompra,
                    $"COMPRA No. {compra.IdCompra}",
                    $"FECHA: {compra.Fecha:d}",
                    "PROVEEDOR:",
                    compra.Proveedor.Nombre,
                    "TOTAL",
                    totalCompra
                 );
                dgvCompras.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                dgvCompras.Rows[rowIndex].Height = 50;

                foreach (var producto in detallesCompra)
                {
                    dgvCompras.Rows.Add(
                        compra.IdCompra,
                        producto.IdProducto,
                        producto.Marca.Nombre,
                        producto.Nombre,
                        producto.Stock,
                        producto.PrecioCompra,
                        producto.PrecioCompra * producto.Stock
                    );
                }
            }

            lblCompras.Text = totalCompras.ToString();
        }

        #endregion

        #region Reportes

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportesClosedXML reportes = new();
            reportes.Excel("Compras", dgvCompras);
        }

        private void btnPDFCompra_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ninguna compra seleccionada");
                return;
            }

            int idCompra = Convert.ToInt32(dgvCompras.CurrentRow.Cells["IdCompra"].Value);
            var compra = D_Compras.CompraPorId(idCompra);
            var document = new ReporteUnaCompra(compra!);

            string fechaHoraConversion = DateTime.Now.ToString("dd-MM-yyyy__HH-mm-ss");
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Compra-No-{idCompra}__{fechaHoraConversion}.pdf");

            // Generar PDF y guardar en la ruta especificada
            document.GeneratePdf(filePath);

            MessageBox.Show("Guardado en el escritorio.");
        }

        private void btnPDFReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;
            var compras = D_Compras.ComprasPorFechas(fechaInicio, fechaFin);
            var document = new ReporteCompras(compras, fechaInicio, fechaFin);

            string fecha = DateTime.Now.ToString("dd-MM-yyyy__HH-mm-ss");
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"ReporteCompras_{fecha}.pdf");

            // Generar PDF y guardar en la ruta especificada
            document.GeneratePdf(filePath);

            MessageBox.Show("Guardado en el escritorio.");
        }
        
        #endregion

        #region Botones
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpInicio.Value.Date;
                DateTime fechaFin = dtpFin.Value.Date;
                MostrarCompras(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            MostrarCompras();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ningun registro seleccionado");
            };

            DialogResult resultado = MessageBox.Show(
                "Borrar la compra " + dgvCompras.CurrentRow.Cells["IdCompra"].Value +
                "\n\nEsta acción no revierte los precios de los productos si estos fueron modificados por esta compra.",
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            D_Compras.Eliminar(Convert.ToInt32(dgvCompras.CurrentRow.Cells["IdCompra"].Value));

            DateTime fechaInicio = DateTime.MinValue.Date;
            DateTime fechaFin = DateTime.Now.Date;
            MostrarCompras(fechaInicio, fechaFin);
        }

        #endregion
    }
}
