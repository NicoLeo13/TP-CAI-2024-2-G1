using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;


namespace Persistencia
{
    public class ClienteWS
    {
        private const String adminId = "abc27a5f-7f7f-4f11-a244-475c8f0c0e89";

        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            HttpResponseMessage response = WebHelper.GetSinAdminId("Cliente/GetClientes");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Cliente> listadoUsuariosActivos = JsonConvert.DeserializeObject<List<Cliente>>(contentStream);
                return listadoUsuariosActivos;
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new HttpRequestException($"Error al momento de buscar los clientes: {(int)response.StatusCode} - {response.ReasonPhrase}");
            }
        }

        public static Cliente TraerCliente(int dniCliente)
        {
            ClienteWS clienteWS = new ClienteWS();

            try
            {
                List<Cliente> clientes = clienteWS.TraerClientes();

                // Busca el usuario con LINQ
                var clienteEncontrado = clientes.FirstOrDefault(u => u.Dni == dniCliente);

                if (clienteEncontrado != null)
                {
                    Console.WriteLine($"\nUsuario encontrado: {clienteEncontrado.Nombre} {clienteEncontrado.Apellido} - {clienteEncontrado.Id}");
                    return clienteEncontrado;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError de red: {ex.Message}");
                throw new Exception($"Error de red al intentar traer el cliente '{dniCliente}':\n{ex.Message}", ex);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"\nArgumento nulo: {ex.Message}");
                throw new Exception($"Argumento nulo al intentar traer el cliente '{dniCliente}':\n{ex.Message}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError inesperado: {ex.Message}");
                throw new Exception($"Error inesperado al intentar traer el cliente '{dniCliente}':\n{ex.Message}", ex);
            }

            return null;
        }

        public String AgregarCliente(Cliente cliente)
        {
            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("idUsuario", adminId);
            datos.Add("nombre", cliente.Nombre);
            datos.Add("apellido", cliente.Apellido);
            datos.Add("dni", cliente.Dni);
            datos.Add("direccion", cliente.Direccion);
            datos.Add("telefono", cliente.Telefono);
            datos.Add("email", cliente.Email);
            datos.Add("fechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            datos.Add("host", cliente.Host);


            var jsonData = JsonConvert.SerializeObject(datos);

            Console.WriteLine("jsonData Cliente/AgregarCliente: " + jsonData);

            HttpResponseMessage response = WebHelper.Post("Cliente/AgregarCliente", jsonData);

            Console.WriteLine("response Cliente/AgregarCliente: " + response);

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
                throw new Exception("Error al agregar el nuevo cliente.");
            }

            return result;
        }

        public String ModificarCliente(Guid id, string direccion, string telefono, string email)
        {
            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("id", id);
            datos.Add("direccion", direccion);
            datos.Add("telefono", telefono);
            datos.Add("email", email);

            var jsonData = JsonConvert.SerializeObject(datos);

            Console.WriteLine("jsonData Cliente/PatchCliente: " + jsonData);

            HttpResponseMessage response = WebHelper.PatchNoAdmin("Cliente/PatchCliente", jsonData);

            Console.WriteLine("response Cliente/PatchCliente: " + response);

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
                throw new Exception("Error al modificar el cliente.");
            }

            return result;
        }

        public void BajaCliente(Guid idClienteBaja)
        {
            //Dictionary<String, object> datos = new Dictionary<String, object>();

            //datos.Add("id", idClienteBaja);

            //var jsonData = JsonConvert.SerializeObject(datos);


            Console.WriteLine("jsonData Cliente/BajaCliente: " + idClienteBaja);

            HttpResponseMessage response = WebHelper.DeleteSinAdminId("Cliente/BajaCliente", idClienteBaja);

            Console.WriteLine("response Cliente/BajaCliente: " + response);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new HttpRequestException($"Error al eliminar el cliente:\n{errorContent}");
            }
        }

        public void ReactivarCliente(Guid idClienteReactivar)
        {
            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("id", idClienteReactivar);

            var jsonData = JsonConvert.SerializeObject(datos);


            Console.WriteLine("jsonData Cliente/ReactivarCliente: " + jsonData);

            HttpResponseMessage response = WebHelper.Patch("Cliente/ReactivarCliente", jsonData);

            Console.WriteLine("response Cliente/ReactivarCliente: " + response);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new HttpRequestException($"Error al reactivar el cliente:\n{errorContent}");
            }
        }


    }
}
