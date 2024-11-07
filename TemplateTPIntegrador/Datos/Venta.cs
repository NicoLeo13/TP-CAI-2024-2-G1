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
        public Guid idUsuario { get; set; }
        public Guid idCliente { get; set; }
        public Guid idProducto { get; set; }
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
