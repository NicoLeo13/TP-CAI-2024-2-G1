using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;

        public Venta(Guid idCliente, Guid idProducto, Guid idUsuario, int cantidad, int estado, DateTime fechaAlta)
        {
            this.idCliente = idCliente;
            this.idProducto = idProducto;
            this.idUsuario = idUsuario;
            this.cantidad = cantidad;
            this.fechaAlta = fechaAlta;
        }
    }
}
