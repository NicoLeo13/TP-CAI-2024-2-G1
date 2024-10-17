using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Datos;
using Persistencia;

namespace Negocio
{
    public class LoginUsuario
    {
        public (String idUsuario, string responseBody) Login(string username, string password)
        {
            string idUsuario;
            string responseBody;
            
            LoginWS loginWs = new LoginWS();
            (idUsuario, responseBody) = loginWs.login(username, password);
            Debug.WriteLine(idUsuario);

            return (idUsuario, responseBody);
        }

        public string AltaUsuario(UsuarioLocal usuarioLocal)
        {
            LoginWS loginWs = new LoginWS();

            string user;

            user = loginWs.AgregarUsuario(usuarioLocal);

            Debug.WriteLine("usuarioLocal que está enviando LoginNegocio: " + user);

            return user;
        }

        public Guid TraerUsuario(string usuario)
        {
            LoginWS loginWs = new LoginWS();

            // Llama al método que trae los usuarios activos
            List<UsuarioWS> usuariosActivos = loginWs.TraerUsuariosActivos();

            // Busca el usuario que coincide con el usuario proporcionado
            foreach (var usuarioActivo in usuariosActivos)
            {
                if (usuarioActivo.NombreUsuario == usuario)
                {
                    Debug.WriteLine($"Usuario encontrado: {usuarioActivo.Nombre} {usuarioActivo.Apellido} - {usuarioActivo.Id}");
                    return usuarioActivo.Id;
                }
            }

            Guid id = new Guid();
            return id;
        }

    }
}
