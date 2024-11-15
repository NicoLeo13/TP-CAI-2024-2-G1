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
        public Carrito carrito;

        public CarritoManager() 
        {
            carrito = new Carrito();
        }

        public void AgregarProducto(Producto producto, int cantidad, Cliente cliente)
        {
            if (carrito == null)
            {
                carrito = new Carrito();
            }
            
            ItemCarrito Item = new ItemCarrito(producto.Id, producto.Nombre, cantidad, producto.Precio, cliente.Id, producto.IdCategoria);
            carrito.Items.Add(Item);
        }
    }
}
