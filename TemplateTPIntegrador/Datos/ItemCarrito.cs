using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ItemCarrito
    {
        public Guid IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public Guid IdCliente { get; set; }
        public int Categoria { get; set; }

        public ItemCarrito(Guid idProducto, string descripcion, int cantidad, decimal precioUnitario, Guid idCliente, int categoria)
        {
            IdProducto = idProducto;
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = CalcularSubtotal();
            IdCliente = idCliente;
            Categoria = categoria;
        }

        public decimal CalcularSubtotal()
        {
            return Cantidad * PrecioUnitario;
        }
    }
}
