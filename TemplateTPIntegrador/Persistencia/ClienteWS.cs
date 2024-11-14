using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    public class ClienteWS
    {
        private readonly HttpClient _httpClient;

        public ClienteWS()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://tu-url-del-servicio-swagger.com/") };
        }
        public async Task<Cliente> BuscarCliente(int dni)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/Cliente/BuscarPorDni/{dni}");
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Cliente>(jsonResponse);
        }

        public async Task EliminarCliente(int idCliente)
        {
            
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync($"https://api.ejemplo.com/clientes/{idCliente}");
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
