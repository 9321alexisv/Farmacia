
using Farmacia.Datos;
using Farmacia.Presentacion;
using Farmacia.Presentacion.Reportes;
using VistasFarmacia.Entidad;

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

        public void MostrarHistorialVentas()
        {
            D_Compras compras = new();
            List<Compra> todasCompras = compras.ObtenerCompras();

            decimal totalCompras = 0;

            dgvCompras.Rows.Clear();

            foreach (var compra in todasCompras)
            {
                List<DetalleCompra> detallesCompra = compras.ObtenerDetallesCompra(compra.IdCompra);

                // PARA ETIQUETAS GLOBALES CON PROPOSITOS INFORMATIVOS
                decimal totalCompra = detallesCompra.Sum(detalle => detalle.PrecioCompra * detalle.Cantidad);
                totalCompras += totalCompra; // Sumar al total de compra

                // Encabezado de cada venta dentro de la tabla
                int rowIndex = dgvCompras.Rows.Add(
                    $"COMPRA #{compra.IdCompra}",
                    $"PROVEEDOR: {compra.Proveedor}",
                    $"FECHA: {compra.Fecha}",
                    $"TOTAL: {totalCompra}"
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportesClosedXML reportes = new();
            reportes.Excel("Compras", dgvCompras);
        }
    }
}
