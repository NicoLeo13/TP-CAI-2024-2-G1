using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class ProductoService
    {
        public string AgregarProducto(Producto producto)
        {

            ProductoWS productoWS = new ProductoWS();
            string respuestaAgregarProducto = productoWS.AgregarProducto(producto);

            return respuestaAgregarProducto;
        }
    }
} 



