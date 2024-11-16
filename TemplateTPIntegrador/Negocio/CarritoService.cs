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
        public CarritoManager CarritoManager { get; set; }
        private List<Producto> localStorageProducto { get; set; }    //Lista para guardar en local el stock del producto previo a la venta

        public CarritoService()
        {
            CarritoManager = new CarritoManager();
        }

        public void AgregarProducto(Producto producto, int cantidad, Cliente cliente)
        {
            CarritoManager.AgregarProducto(producto, cantidad, cliente);
        }

        //Guarda el stock del producto previo a la venta
        public void GuardarStockProductoLocal(Producto productoBusqueda, int cantidad)
        {
            if (localStorageProducto == null)
                localStorageProducto = new List<Producto>();

            Producto productoLocal = productoBusqueda;
            productoLocal.Stock -= cantidad;
            localStorageProducto.Add(productoLocal);
        }

        public ItemCarrito ProductoYaAgregadoCarrito(Producto productoBusqueda)
        {
            if (CarritoManager == null)
                return null;

            bool productoYaAgregado = false;
            ItemCarrito ItemCarrito = null;

            foreach (ItemCarrito item in CarritoManager.carrito.Items)
            {
                //Si el item fue agregado varias veces, se debe sumar la cantidad
                if (item.IdProducto == productoBusqueda.Id)
                {
                    productoYaAgregado = true;
                    if(ItemCarrito == null)
                    {
                        ItemCarrito = item;
                        continue;
                    }
                    ItemCarrito.Cantidad += item.Cantidad;
                }
            }

            if (productoYaAgregado)
                return ItemCarrito;
            return null;
        }

        public int CantidadProductosEnCarrito()
        {
            if (CarritoManager == null)
                return 0;

            return CarritoManager.carrito.Items.Count;
        }

        public List<ItemCarrito> ObtenerItemsCarrito()
        {
            if (CarritoManager == null)
                return null;

            return CarritoManager.carrito.Items;
        }

        public decimal CalcularTotalCarrito()
        {
            if (CarritoManager == null)
                return 0;

            decimal total = 0;
            foreach (ItemCarrito item in CarritoManager.carrito.Items)
            {
                total += (decimal)item.Subtotal;
            }
            return total;
        }

        public void EliminarItemCarrito(ItemCarrito producto)
        {
            if (CarritoManager == null)
                return;

            foreach (ItemCarrito item in CarritoManager.carrito.Items)
            {
                if (item == producto)
                {
                    CarritoManager.carrito.Items.Remove(item);
                    break;
                }
            }
        }
    }
}
