using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class VentaService
    {
        private readonly VentaWS ventaWs;

        public VentaService()
        {
            ventaWs = new VentaWS();
        }

        public void AgregarVenta(Venta venta)
        {
            try
            {
                ventaWs.AgregarVenta(venta);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError de WS: {ex.ToString()}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError Inesperado: {ex.ToString()}");
                throw;
            }

        }
        public Dictionary<string,object> ObtenerVentaPorVenta(Guid idVenta)
        {
            var ventaWs = new VentaWS();
            var venta = ventaWs.ObtenerVentaPorId(idVenta);
            return venta;
        }


        public void DevolverVenta(Guid id)
        {
            try
            {
                ventaWs.DevolverVenta(id);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError de WS: {ex.ToString()}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError Inesperado: {ex.ToString()}");
                throw;
            }
        }


    }
}
