using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        string contraseña;
        string contraseñanueva;

        //IndexOf devuelve el índice de la primera aparición de una subcadena en otra, y con StringComparison.OrdinalIgnoreCase ignora las diferencias entre mayúsculas y minúsculas. Si no se encuentra la subcadena, devuelve -1. Por eso verificamos si es mayor o igual a 0.
        public bool ValidarUsuario(string usuario, string nombre, string apellido)
        {
            if (usuario.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0 || usuario.IndexOf(apellido, StringComparison.OrdinalIgnoreCase) >= 0)
                return true;
            return false;
        }




        public bool ValidarTexto(string contraseña) //Validacion de que la pass o usuario tenga entre 8 y 15 caracteres
        {
            if (contraseña.Length >= 8 && contraseña.Length <=15 )
                return true;
            return false;
        }

        //Validacion que la nueva contraseña no sea igual a la contraseña actual
        public bool ValidarPass (string contraseña, string contraseñanueva)
        {
            if (contraseña == contraseñanueva)
            return true;
            return false;
        }

        }
}
