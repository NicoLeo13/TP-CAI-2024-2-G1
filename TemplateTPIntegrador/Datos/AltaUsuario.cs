using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AltaUsuario
    {
        //atributos
        string _idusuario;
        string _nombre;
        string _apellido;
        string _direccion;
        string _telefono;
        string _mail;
        int _dni;
        string _usuario;
        string _contraseña;
        byte _host;
        DateTime _fechanacimiento;

        //constructor
        public AltaUsuario(
        string idusuario,
        string nombre,
        string apellido,
        string direccion,
        string telefono,
        string mail,
        int dni,
        string usuario,
        string contraseña,
        byte host,
        DateTime fechanacimiento)

        {
            _idusuario = idusuario;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _mail = mail;
            _dni = dni;
            _usuario = usuario;
            _contraseña = contraseña;
            _host = host;
            _fechanacimiento = fechanacimiento;

        }

        //Encapsulamiento
        public string Idusuario
        {
            get
            {
                return _idusuario;
            }
            set
            {
                _idusuario = value;
            }

        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }

        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }

        }
        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }

        }
        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }

        }

        public string Mail
        {
            get
            {
                return _mail;
            }
            set
            {
                _mail = value;
            }

        }
        public int DNI
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }

        }
        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }

        }
        public string Contraseña
        {
            get
            {
                return _contraseña;
            }
            set
            {
                _contraseña = value;
            }

        }

        public byte Host
        {
            get
            {
                return _host;
            }
            set
            {
                _host = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechanacimiento;
            }
            set
            {
                _fechanacimiento = value;
            }
        }

    }
}
