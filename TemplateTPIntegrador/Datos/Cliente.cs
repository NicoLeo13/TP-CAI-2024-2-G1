using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente
    {
        public Guid _id { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public int _dni { get; set; }
        public string _direccion { get; set; }
        public string _telefono { get; set; }
        public string _email { get; set; }
        public DateTime _fechaNacimiento { get; set; }
        public DateTime? _fechaAlta { get; set; }
        public DateTime? _fechaBaja { get; set; }
        public string _host { get; set; }

        public Cliente(Guid id, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, DateTime? fechaAlta = null, DateTime? fechaBaja = null, string host = null)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Host = host;
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string Host { get; set; }
    }
}
