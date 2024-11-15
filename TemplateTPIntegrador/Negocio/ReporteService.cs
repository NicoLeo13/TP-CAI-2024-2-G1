using Datos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Negocio
{
    public class ReporteService
    {
        public ReporteService()
        {

        }

        public void GenerarReporteExcelVentas(List<Venta> ventas)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                using (ExcelPackage excel = new ExcelPackage())
                {
                    excel.Workbook.Worksheets.Add("ReporteVentas");
                    var hoja = excel.Workbook.Worksheets["ReporteVentas"];

                    hoja.Cells[1, 1].Value = "ID Venta";
                    hoja.Cells[1, 2].Value = "Fecha";
                    hoja.Cells[1, 3].Value = "Cliente";
                    hoja.Cells[1, 4].Value = "Total";

                    int fila = 2;
                    foreach (var venta in ventas)
                    {
                        hoja.Cells[fila, 1].Value = venta.IdVenta;
                        hoja.Cells[fila, 2].Value = venta.FechaAlta;
                        hoja.Cells[fila, 3].Value = venta.IdCliente;
                        hoja.Cells[fila, 4].Value = venta.Cantidad;
                        fila++;
                    }

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        saveFileDialog.FileName = "ReporteVentas.xlsx";
                        saveFileDialog.Title = "Guardar reporte de ventas";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string ruta = saveFileDialog.FileName;
                            File.WriteAllBytes(ruta, excel.GetAsByteArray());
                            MessageBox.Show("Reporte generado exitosamente en " + ruta);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }
    }
}
