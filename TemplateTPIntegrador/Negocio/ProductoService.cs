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

        public static Producto BuscarProducto(string nombre)
        {
            try
            {
                return ProductoWS.TraerProducto(nombre);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al buscar el producto: {ex.Message}");
                throw;
            }
        }

        public void EliminarProducto(Producto producto)
        {
            try
            {
                ProductoWS persistencia = new ProductoWS();
                persistencia.EliminarProducto(producto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al buscar el producto: {ex.Message}");
                throw;
            }

        }
    }
} 



