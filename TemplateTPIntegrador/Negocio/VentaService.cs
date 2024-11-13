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

        public string AgregarVenta(Venta venta)
        {

            var ventaWs = new VentaWS();
            return ventaWs.AgregarVenta(venta);

        }
        public string ObtenerVentaPorVenta(Guid idVenta)
        {
            var ventaWs = new VentaWS();
            var venta = ventaWs.ObtenerVentaPorId(idVenta);
            return venta != null ? venta.ToString() : string.Empty;
        }

        private readonly VentaBuscar _ventaBuscar;

        public VentaService()
        {
            _ventaBuscar = new VentaBuscar();
        }
        public async Task<List<Venta>> BuscarVentasCliente(int clienteId, string empresa, DateTime fechaCompra)
        {
            return await _ventaBuscar.ObtenerVentasCliente(clienteId, empresa, fechaCompra);
        }


        public async Task<bool> DevolverVenta(int id, Guid idUsuario)
        {
            var ventaWs = new VentaWS();
            var result = await ventaWs.DevolverVenta(id, idUsuario);
            return result != null && result.Count > 0;
        }


    }
}
