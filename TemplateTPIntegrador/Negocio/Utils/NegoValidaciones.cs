using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Utils
{
    public class NegocioValidaciones
    {
        string usuario;
        string nombre;
        string apellido;

        public bool Login(string usuario) 
        {
            if(usuario.Length < 8) 
                return true;
            return false;
        }


        public bool ValidarUsuario(string usuario, string nombre, string apellido) //Validacion de que el user no contenga el nombre y el apellido
        {
            if (usuario.Contains(nombre, StringComparison.OrdinalIgnoreCase) ||
                     usuario.Contains(apellido, StringComparison.OrdinalIgnoreCase))
            return true;
            return false;
        }

        }
}
