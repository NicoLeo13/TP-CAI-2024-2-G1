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
    public class CarritoService

    {
        public CarritoManager Carrito { get; set; }

        public CarritoService(Guid idProducto, string descripcion, int cantidad, decimal precioUnitario)
        {
            Carrito = new CarritoManager();
        }

        public void AgregarProducto(Producto producto)
        {
            Carrito.AgregarProducto(producto);
        }



        //public decimal CalcularSubtotal()
        //{
        //    return Cantidad * PrecioUnitario;
        //}
    }
}
