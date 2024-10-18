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
            string statusCode;
            
            LoginDB loginDB = new LoginDB();
            LoginWS loginWs = new LoginWS();

            // Obtiene el intento de login
            (int intentos, DateTime tmsTmp) = loginDB.obtenerIntentos(username);
            if (intentos >= 3)
            {
                TimeSpan diff = DateTime.Now - tmsTmp;
                if (diff.TotalMinutes < 5)
                {
                    Debug.WriteLine($"Usuario bloqueado por: {diff.TotalMinutes} minutos y {diff.Seconds} segundos");
                    return (null, $"Usuario bloqueado por: {diff.TotalMinutes} minutos y {diff.Seconds} segundos");
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

        public Guid TraerUsuario(string usuario)
        {
            UserManager userManager = new UserManager();

            //Bloque try-catch para manejar excepciones en TraerUsuariosActivos
            try
            {
                List<UsuarioWS> usuariosActivos = userManager.TraerUsuariosActivos();

                // Busca el usuario que coincide con el usuario proporcionado
                foreach (var usuarioActivo in usuariosActivos)
                {
                    if (usuarioActivo.NombreUsuario == usuario)
                    {
                        Debug.WriteLine($"\nUsuario encontrado: {usuarioActivo.Nombre} {usuarioActivo.Apellido} - {usuarioActivo.Id}");
                        return usuarioActivo.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"\nError al traer usuarios activos: {ex.Message}");
            }

            Guid id = new Guid();
            return id;
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
