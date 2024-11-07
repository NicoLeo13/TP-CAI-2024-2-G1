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

namespace Persistencia
{
    public class VentaWS
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaAlta { get; set; }
        public string AgregarVenta(Venta venta)
        {

            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("IdVenta", venta.IdVenta);
            datos.Add("IdCliente", venta.IdCliente);
            datos.Add("IdProducto", venta.IdProducto);
            datos.Add("Cantidad", venta.Cantidad);
            datos.Add("FechaAlta", venta.FechaAlta);
            datos.Add("Estado", venta.Estado);
            datos.Add("IdUsuario", venta.IdUsuario);

            //Convert the data to a JSON string
            var jsonData = JsonConvert.SerializeObject(datos);

            Console.WriteLine("\n jsonData para Venta/AgregarVenta: " + jsonData);

            HttpResponseMessage response = WebHelper.Post("Venta/AgregarVenta", jsonData);

            Console.WriteLine("\n response Venta/AgregarVenta: " + response);

            string result;

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                result = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
            }
            else
            {
                result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {result}");
                throw new Exception("Error al guardar producto." + response.ReasonPhrase);
            }

            return result;
        }
        public Venta ObtenerVentaPorId(Guid idVenta)
        {
            string url = $"https://api.swaggerendpoint.com/ventas/{idVenta}";
            HttpResponseMessage response = WebHelper.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Venta>(json);
            }
            else
            {
                throw new Exception("Error al obtener la venta desde el servicio.");
            }
        }
    }
}

