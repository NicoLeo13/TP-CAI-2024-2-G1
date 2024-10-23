using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioLocal
    {
        private Guid _idUsuario;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _email;
        private DateTime _fechaAlta;
        private DateTime _fechaNacimiento;
        private DateTime _fechaBaja;
        private string _nombreUsuario;
        private int _host;
        private int _dni;
        private string _contraseña;

        public UsuarioLocal(Guid idUsuario, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime fechaBaja, string nombreUsuario, int host, int dni, string contraseña)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaAlta = fechaAlta;
            FechaNacimiento = fechaNacimiento;
            FechaBaja = fechaBaja;
            NombreUsuario = nombreUsuario;
            Host = host;
            Dni = dni;
            Contraseña = contraseña;
        }


        public Guid IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaBaja { get; set; }
        public string NombreUsuario { get; set; }
        public int Host { get; set; }
        public int Dni { get; set; }
        public string Contraseña { get; set; }
    }
}
