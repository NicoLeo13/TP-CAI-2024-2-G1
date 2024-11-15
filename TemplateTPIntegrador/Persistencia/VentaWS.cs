using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class VentaWS
    {
        private const String adminId = "abc27a5f-7f7f-4f11-a244-475c8f0c0e89";
        public void AgregarVenta(Venta venta)
        {

            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("idCliente", venta.IdCliente);
            datos.Add("idUsuario", venta.IdUsuario);
            datos.Add("idProducto", venta.IdProducto);
            datos.Add("cantidad", venta.Cantidad);

            //Convert the data to a JSON string
            var jsonData = JsonConvert.SerializeObject(datos);

            Console.WriteLine("\n jsonData para Venta/AgregarVenta: " + jsonData);

            HttpResponseMessage response = WebHelper.Post("Venta/AgregarVenta", jsonData);

            Console.WriteLine("\n response Venta/AgregarVenta: " + response);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                Console.WriteLine($"Venta de producto ID: {venta.IdProducto} - Cantidad:{venta.Cantidad}");
                throw new HttpRequestException($"Error al agregar la venta:\n{errorContent}");
            }
        }

        public void DevolverVenta(Guid id)
        {
            try
            {
                Dictionary<String, object> datos = new Dictionary<String, object>();

                datos.Add("id", id);
                datos.Add("idUsuario", adminId);

                var jsonData = JsonConvert.SerializeObject(datos);

                Console.WriteLine("\n jsonData para Venta/DevolverVenta: " + jsonData);

                HttpResponseMessage response = WebHelper.PatchNoAdmin("Venta/DevolverVenta", jsonData);

                Console.WriteLine("\n response Venta/DevolverVenta: " + response);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"Error: {errorContent}");
                    throw new HttpRequestException($"Error al devolver la venta:\n{errorContent}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la venta por ID: {ex.Message}");
                throw;
            }
        }

        public Dictionary<string, object> ObtenerVentaPorId(Guid idVenta)
        {
            try
            {
                Console.WriteLine("\n jsonData para Venta/GetVenta: " + idVenta);

                HttpResponseMessage response = WebHelper.GetCustomId("Venta/GetVenta", idVenta);

                Console.WriteLine("\n response Venta/GetVenta: " + response);

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    // Deserializar a un diccionario
                    return JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                }
                else
                {
                    throw new Exception("Error al obtener la venta desde el servicio.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la venta por ID: {ex.Message}");
                return null;
            }
        }
    }
}



