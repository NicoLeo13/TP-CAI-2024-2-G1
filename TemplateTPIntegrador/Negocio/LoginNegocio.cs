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

        public Guid TraerUsuario(string usuario)
        {
            LoginWS loginWs = new LoginWS();

            // Llama al método que trae los usuarios activos
            List<UsuarioWS> usuariosActivos = loginWs.traerUsuariosActivos();

            // Busca el usuario que coincide con el usuario proporcionado
            foreach (var usuarioActivo in usuariosActivos)
            {
                if (usuarioActivo.NombreUsuario == usuario)
                {
                    Console.WriteLine($"Usuario encontrado: {usuarioActivo.Nombre} {usuarioActivo.Apellido} - {usuarioActivo.Id}");
                    return usuarioActivo.Id;
                }
            }

            throw new Exception("Usuario no encontrado");
        }

    }
}
