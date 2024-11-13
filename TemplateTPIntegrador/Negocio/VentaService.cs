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
            
            var ventaWS = new VentaWS();
            return ventaWS.AgregarVenta(venta);

        }
        public Datos.Venta ObtenerVentaPorVenta(Guid idVenta)
        {
            var ventaWS = new VentaWS();
            return ventaWS.ObtenerVentaPorId(idVenta);
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
        public class VentaNegocio
        {
            private readonly VentaDatos _ventaDatos;

            public VentaNegocio(VentaDatos ventaDatos)
            {
                _ventaDatos = ventaDatos;
            }

            public async Task<bool> DevolverVenta(int id, int idUsuario)
            {
                return await _ventaDatos.DevolverVenta(id, idUsuario);
            }
        }
    }
}
