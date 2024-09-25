using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
