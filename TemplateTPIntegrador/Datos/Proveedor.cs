using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Proveedor
    {
        private Guid _id;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _cuit;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;


        public Guid Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string CUIT { get { return _cuit; } set { _cuit = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { _fechaAlta = value; } }
        public DateTime? FechaBaja { get { return _fechaBaja; } set { _fechaBaja = value; } }

        public Proveedor(Guid id, string nombre, string apellido, string email, string cuit, DateTime fechaAlta, DateTime? fechaBaja)
        {
            this.Id= id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.CUIT = cuit;
            this.FechaAlta = fechaAlta;
            this.FechaBaja = fechaBaja;
        }
    }
}
