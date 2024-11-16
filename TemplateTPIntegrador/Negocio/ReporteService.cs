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

        public List<Producto> ComprobarStockCritico(List<Producto> productos, int critico)
        {
            List<Producto> productosCriticos = new List<Producto>();

            foreach (var producto in productos)
            {
                if (producto.Stock <= critico)
                    productosCriticos.Add(producto);
            }

            return productosCriticos;
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
                            MessageBox.Show("Reporte generado exitosamente en " + ruta, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarReporteExcelStockCritico(List<Producto> productos, int critico)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                using (ExcelPackage excel = new ExcelPackage())
                {
                    excel.Workbook.Worksheets.Add("ReporteStockCritico");
                    var hoja = excel.Workbook.Worksheets["ReporteStockCritico"];

                    hoja.Cells[1, 1].Value = "ID Producto";
                    hoja.Cells[1, 2].Value = "Nombre";
                    hoja.Cells[1, 3].Value = "Stock";
                    hoja.Cells[1, 2].Value = "Precio";

                    int fila = 2;
                    foreach (var producto in productos)
                    {
                        hoja.Cells[fila, 1].Value = producto.Id;
                        hoja.Cells[fila, 2].Value = producto.Nombre;
                        hoja.Cells[fila, 3].Value = producto.Stock;
                        hoja.Cells[fila, 2].Value = producto.Precio;
                        fila++;
                    }

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        saveFileDialog.FileName = "ReporteStockCritico.xlsx";
                        saveFileDialog.Title = "Guardar reporte de stock critico";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string ruta = saveFileDialog.FileName;
                            File.WriteAllBytes(ruta, excel.GetAsByteArray());
                            MessageBox.Show("Reporte generado exitosamente en " + ruta, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para generar reporte de ventas por vendedor
        public void GenerarReporteExcelVentasPorVendedor(List<Venta> ventas)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                using (ExcelPackage excel = new ExcelPackage())
                {
                    excel.Workbook.Worksheets.Add("ReporteVentasPorVendedor");
                    var hoja = excel.Workbook.Worksheets["ReporteVentasPorVendedor"];

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
                        saveFileDialog.FileName = "ReporteVentasPorVendedor.xlsx";
                        saveFileDialog.Title = "Guardar reporte de ventas por vendedor";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string ruta = saveFileDialog.FileName;
                            File.WriteAllBytes(ruta, excel.GetAsByteArray());
                            MessageBox.Show("Reporte generado exitosamente en " + ruta, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
