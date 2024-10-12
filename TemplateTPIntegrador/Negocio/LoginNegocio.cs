using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class LoginNegocio
    {
        public string Login(string username, string password)
        {
            string idUsuario;
            
            LoginWS loginWs = new LoginWS();
            idUsuario = loginWs.login(username, password);
            Console.WriteLine(idUsuario);

            return idUsuario;
        }

        public string AltaUsuario(UsuarioLocal usuarioLocal)
        {
            LoginWS loginWs = new LoginWS();

            string user;

            user = loginWs.AgregarUsuario(usuarioLocal);

            Console.WriteLine("usuarioLocal que está enviando LoginNegocio: " + user);

            return user;
        }


    }
}
