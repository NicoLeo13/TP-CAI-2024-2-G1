using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Datos
{
    public class Producto
    {
        private int _idCategoria;
        private Guid _id;           //Usado para el get de un producto (idproducto)
        private Guid _idUsuario;
        private Guid _idProveedor;
        private string _nombre;
        private int _precio;
        private int _stock;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;

        public Guid Id { get { return _id; } set { _id = value; } }
        public int IdCategoria { get { return _idCategoria; } set { _idCategoria = value; } }
        public Guid IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public Guid IdProveedor { get { return _idProveedor; } set { _idProveedor = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int Precio { get { return _precio; } set { _precio = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { _fechaAlta = value; } }
        public DateTime? FechaBaja { get { return _fechaBaja; } set { _fechaBaja = value; } }

        public Producto(int idCategoria, Guid idUsuario, Guid idProveedor, string nombre, int precio, int stock, DateTime fechaAlta, DateTime? fechaBaja)
        {
            IdCategoria = idCategoria;
            IdUsuario = idUsuario;
            IdProveedor = idProveedor;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
        }

        // Constructor de sobrecarga para Get
        [JsonConstructor]
        public Producto(Guid id, int idCategoria, string nombre, DateTime fechaAlta, int precio, int stock, DateTime? fechaBaja)
        {
            Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
            FechaAlta = DateTime.Now; // Asignar la fecha actual como fecha de alta
            FechaBaja = fechaBaja;
            Precio = precio;
            Stock = stock;
        }

    }
}
