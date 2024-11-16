using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



namespace Datos
{
    public class Venta
    {
        public Guid IdVenta { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAlta { get; set; } = DateTime.Now;
        public int Estado { get; set; } = -1;   // Para que no se inicialice en los estados 0 o 1
        public Guid IdUsuario { get; set; }

        public Venta(Guid idVenta, Guid idCliente, Guid idProducto, int cantidad, DateTime fechaAlta, int estado, Guid idUsuario)
        {
            IdVenta = idVenta;
            IdCliente = idCliente;
            IdProducto = idProducto;
            Cantidad = cantidad;
            FechaAlta = fechaAlta;
            Estado = estado;
            IdUsuario = idUsuario;
        }

        // Constructor de sobrecarga para agregar una venta vs API
        public Venta(Guid idCliente, Guid idUsuario, Guid idProducto, int cantidad)
        {
            IdCliente = idCliente;
            IdUsuario = idUsuario;
            IdProducto = idProducto;
            Cantidad = cantidad;
        }

        //Constructor de sobrecarga para GetVentaByCliente
        public Venta(Guid idVenta, int cantidad, DateTime fechaAlta, int estado)
        {
            IdVenta = idVenta;
            Cantidad = cantidad;
            FechaAlta = fechaAlta;
            Estado = estado;
        }
    }
}
