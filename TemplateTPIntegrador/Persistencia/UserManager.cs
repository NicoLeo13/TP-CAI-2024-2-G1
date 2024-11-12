using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using Persistencia.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Persistencia
{
    public class UserManager
    {
        private const String adminId = "abc27a5f-7f7f-4f11-a244-475c8f0c0e89";
        private const String rutaBase = "https://cai-tp.azurewebsites.net/api/";

        public List<UsuarioWS> TraerUsuariosActivos()
        {
            List<UsuarioWS> clientes = new List<UsuarioWS>();

            HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<UsuarioWS> listadoUsuariosActivos = JsonConvert.DeserializeObject<List<UsuarioWS>>(contentStream);
                return listadoUsuariosActivos;
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new HttpRequestException($"Error al momento de buscar los usuarios: {(int)response.StatusCode} - {response.ReasonPhrase}");
            }
        }

        public async Task<(List<UsuarioWS>, string)> TraerUsuariosActivosAsync()
        {
            const string url = "Usuario/TraerUsuariosActivos?id=";

            try
            {
                HttpResponseMessage response = await WebHelper.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<UsuarioWS> usuariosActivos = JsonConvert.DeserializeObject<List<UsuarioWS>>(jsonResponse);

                return (usuariosActivos, null);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return (null, $"Error al momento de buscar los usuarios activos: {ex.Message}");
            }
            catch (HttpResponseMessageException ex)
            {
                var errorContent = await ex.Response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {(int)ex.Response.StatusCode} - {ex.Response.ReasonPhrase}");
                return (null, $"Error al momento de buscar los usuarios activos: {(int)ex.Response.StatusCode} - {ex.Response.ReasonPhrase}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado al obtener usuarios activos:\n" + ex.Message);
                return (null, $"Error inesperado al obtener usuarios activos: - {ex.Message}");
            }
        }

        public static UsuarioWS TraerUsuario(string usuario)
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
                    Console.WriteLine($"\nUsuario encontrado: {usuarioEncontrado.Nombre} {usuarioEncontrado.Apellido} - {usuarioEncontrado.Id}");
                    return usuarioEncontrado;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError de red: {ex.Message}");
                throw new Exception($"Error de red al intentar traer el usuario '{usuario}':\n{ex.Message}", ex);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"\nArgumento nulo: {ex.Message}");
                throw new Exception($"Argumento nulo al intentar traer el usuario '{usuario}':\n{ex.Message}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError inesperado: {ex.Message}");
                throw new Exception($"Error inesperado al intentar traer el usuario '{usuario}':\n{ex.Message}", ex);
            }

            return null;
        }

        public String AgregarUsuarioOld(UsuarioLocal usuarioLocal)
        {
            Dictionary<String, object> datos = new Dictionary<String, object>();

            //var userData = new
            datos.Add("idUsuario", adminId);
            datos.Add("host", usuarioLocal.Host);
            datos.Add("nombre", usuarioLocal.Nombre);
            datos.Add("apellido", usuarioLocal.Apellido);
            datos.Add("dni", usuarioLocal.Dni);
            datos.Add("direccion", usuarioLocal.Direccion);
            datos.Add("telefono", usuarioLocal.Telefono);
            datos.Add("email", usuarioLocal.Email);

            // Formatear la fecha de nacimiento en formato UTC
            datos.Add("fechaNacimiento", usuarioLocal.FechaNacimiento.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));

            //datos.Add("fechaNacimiento", usuarioLocal.FechaNacimiento);
            datos.Add("nombreUsuario", usuarioLocal.NombreUsuario);
            datos.Add("contraseña", usuarioLocal.Contraseña);


            var jsonData = JsonConvert.SerializeObject(datos);

            Console.WriteLine("jsonData Usuario/AgregarUsuario: " + jsonData);

            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonData);

            Console.WriteLine("response Usuario/AgregarUsuario: " + response);

            String result;

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                result = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new Exception("Error al crear el nuevo usuario.");
            }

            return result;
        }

        //Metodo para agregar un usuario al web service, sin usar dictionary
        public void AgregarUsuario(UsuarioLocal usuarioLocal)
        {
            var jsonData = JsonConvert.SerializeObject(usuarioLocal);

            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonData);
            //String result;

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                //result = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new HttpRequestException($"Error al crear el nuevo usuario:\n{errorContent}");
            }
        }

        public string CambiarContraseñaUsuario(string nombreUsuario, string contraseñaActual, string nuevaContraseña)
        {

            Dictionary<String, object> datos = new Dictionary<String, object>();

            //var userData = new
            datos.Add("nombreUsuario", nombreUsuario);
            datos.Add("contraseña", contraseñaActual);
            datos.Add("contraseñaNueva", nuevaContraseña);


            var jsonData = JsonConvert.SerializeObject(datos);

            Console.WriteLine("\n jsonData /Usuario/CambiarContraseña: " + jsonData);

            //HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonData);
            HttpResponseMessage response = WebHelper.PatchNoAdmin("Usuario/CambiarContraseña", jsonData);


            Console.WriteLine("\n response Usuario/AgregarUsuario: " + response);

            String result;

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                result = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new Exception("Error al cambiar la contraseña:\n" + errorContent);
            }

            return result;
        }

        public void EliminarUsuario(UsuarioWS usuario)
        {
            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("id", usuario.Id);
            datos.Add("idUsuario", adminId);

            var jsonData = JsonConvert.SerializeObject(datos);

            HttpResponseMessage response = WebHelper.DeleteWithBody("Usuario/BajaUsuario", jsonData);
            //HttpResponseMessage response = WebHelper.Delete("Usuario/BajaUsuario", "idUsuario", idUsuario.ToString());

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new HttpRequestException($"Error al eliminar el usuario:\n{errorContent}");
            }
        }

        public void ReactivarUsuario(Guid idUsuarioReactivar)
        {
            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("id", idUsuarioReactivar);
            datos.Add("idUsuario", adminId);

            var jsonData = JsonConvert.SerializeObject(datos);

            HttpResponseMessage response = WebHelper.Patch("Usuario/ReactivarUsuario", jsonData);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new HttpRequestException($"Error al reactivar el usuario:\n{errorContent}");
            }
        }

    }
}
