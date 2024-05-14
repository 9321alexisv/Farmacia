
using ClosedXML.Excel;

namespace Farmacia.Presentacion.Reportes
{
    public class ReportesClosedXML
    {
        public void Excel(DataGridView dgvRegistros)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Datos");

                // Agregar cabeceras
                for (int j = 0; j < dgvRegistros.Columns.Count; j++)
                {
                    worksheet.Cell(1, j + 1).Value = dgvRegistros.Columns[j].Name;
                }

                // Agregar datos
                for (int i = 0; i < dgvRegistros.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvRegistros.Columns.Count; j++)
                    {
                        object value = dgvRegistros.Rows[i].Cells[j].Value;
                        if (value != null)
                        {
                            if (value is double || value is int || value is float || value is decimal)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = Convert.ToDouble(value);
                            }
                            else
                            {
                                worksheet.Cell(i + 2, j + 1).Value = value.ToString();
                            }
                        }
                        else
                        {
                            worksheet.Cell(i + 2, j + 1).Value = "";
                        }
                    }
                }

                // Obtener la fecha y hora actual
                DateTime fechaHora = DateTime.Now;
                string fechaHoraConversion = fechaHora.ToString("dd-MM-yyyy__HH-mm-ss");

                // Guardar en el escritorio
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string rutaArchivo = Path.Combine(escritorio, $"{fechaHoraConversion}.xlsx");
                workbook.SaveAs(rutaArchivo);

                MessageBox.Show("Guardado en el Escritorio", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
