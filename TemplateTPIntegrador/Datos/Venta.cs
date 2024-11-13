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
        public int IdVenta { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAlta { get; set; } = DateTime.Now;
        public int Estado { get; set; } = -1;   // Para que no se inicialice en los estados 0 o 1
        public Guid IdUsuario { get; set; }

        public Venta(Guid idVenta, Guid idCliente, Guid idProducto, int cantidad, DateTime fechaAlta, int estado, Guid idUsuario)
        {
            IdVenta = IdVenta;
            IdCliente = idCliente;
            IdProducto = idProducto;
            Cantidad = cantidad;
            FechaAlta = fechaAlta;
            Estado = estado;
            IdUsuario = idUsuario;
        }

    }
}
