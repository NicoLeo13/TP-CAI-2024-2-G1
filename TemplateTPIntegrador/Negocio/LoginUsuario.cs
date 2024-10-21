using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Datos;
using Persistencia;
using System.Net.Http;

namespace Negocio
{
    public class LoginUsuario
    {
        private const int LOCK_TIME = 5;
        
        public (String idUsuario, string responseBody) Login(string username, string password)
        {
            string idUsuario;
            string responseBody;
            string statusCode;
            
            LoginDB loginDB = new LoginDB();
            LoginWS loginWs = new LoginWS();

            // Obtiene el intento de login
            (int intentos, DateTime tmsTmp) = loginDB.obtenerIntentos(username);
            if (intentos >= 3)
            {
                DateTime lockedUntil = tmsTmp.AddMinutes(LOCK_TIME);
                if (DateTime.Now < lockedUntil)
                {
                    Debug.WriteLine($"Usuario bloqueado por: {LOCK_TIME} minutos");
                    return (null, $"Usuario bloqueado por: {LOCK_TIME} minutos.\nVuelva a intentar en el siguiente horario: {lockedUntil.ToShortTimeString()}hs");
                }
                else
                {
                    loginDB.reiniciarIntentos(username);
                    intentos = 0;
                }
            }
            // Guarda el intento de login
            loginDB.guardarIntento(username, intentos);

            (idUsuario, responseBody, statusCode) = loginWs.login(username, password);
            Debug.WriteLine(idUsuario);

            //Si el login es exitoso, reinicia los intentos
            if (idUsuario != null && int.Parse(statusCode) == 200)
                loginDB.reiniciarIntentos(username);

            return (idUsuario, responseBody);
        }

        public UsuarioWS TraerUsuario(string usuario)
        {
            UserManager userManager = new UserManager();

            try
            {
                // Llama al método que trae los usuarios activos
                List<UsuarioWS> usuariosActivos = userManager.TraerUsuariosActivos();

                // Busca el usuario con LINQ
                var usuarioEncontrado = usuariosActivos.FirstOrDefault(u => u.NombreUsuario == usuario);

                if (usuarioEncontrado != null)
                {
                    Debug.WriteLine($"\nUsuario encontrado: {usuarioEncontrado.Nombre} {usuarioEncontrado.Apellido} - {usuarioEncontrado.Id}");
                    return usuarioEncontrado;
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine($"\nError de red: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Debug.WriteLine($"\nArgumento nulo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"\nError al traer usuarios activos: {ex.Message}");
            }

            return null;
        }

        //public string AltaUsuario(UsuarioLocal usuarioLocal)
        //{
        //    string user;

        //    UserManager userManager = new UserManager();
        //    user = userManager.AgregarUsuario(usuarioLocal);

        //    Debug.WriteLine("usuarioLocal que está enviando LoginNegocio: " + user);

        //    return user;
        //}

    }
}
