using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class VentaService
    {
        public string AgregarVenta(Datos.Venta venta)
        {
            
            var ventaWS = new VentaWS();
            return ventaWS.AgregarVenta(venta);

        }
    }
}
