using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Persistencia
{
    public class CarritoManager
    {
        private Carrito carrito;

        public CarritoManager() 
        {
            Carrito carrito = new Carrito();
        }

        public void AgregarProducto(Producto producto)
        {
            carrito.Productos.Add(producto);
        }
    }
}
