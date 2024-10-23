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
        private const String adminId = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
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
                Console.WriteLine("Error insesperado al obtener usuarios activos:\n" + ex.Message);
                return (null, $"Error insesperado al obtener usuarios activos: - {ex.Message}");
            }
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

    }
}
