using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Proveedor
    {
        private Guid _idusuario;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _cuit;


        public Guid IdUsuario { get { return _idusuario; } set { _idusuario = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string CUIT { get { return _cuit; } set { _cuit = value; } }

        public Proveedor(Guid idusuario, string nombre, string apellido, string email, string cuit)
        {
            this.IdUsuario = idusuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.CUIT = cuit;

        }
    }
}
