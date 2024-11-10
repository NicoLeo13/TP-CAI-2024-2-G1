using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class VentaBuscar
    {
        private readonly HttpClient _httpClient;

        public VentaBuscar()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://tu-api-url-swagger.com");
        }

        public async Task<List<Venta>> ObtenerVentasCliente(int clienteId, string empresa, DateTime fechaCompra)
        {
            var query = $"api/ventas?clienteId={clienteId}&empresa={empresa}&fechaCompra={fechaCompra:yyyy-MM-dd}";
            var response = await _httpClient.GetAsync(query);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Venta>>(jsonResponse);
            }

            return null; 
        }
    }
}
