using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Persistencia
{
    public class ProductoWS
    {
        public string AgregarProducto(Producto producto)
        {
            //string idUsuario = "";
            //string responseBody = "";

            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("idCategoria", producto.idCategoria);
            datos.Add("idUsuario", producto.idUsuario);
            datos.Add("idProveedor", producto.idProveedor);
            datos.Add("nombre", producto.nombre);
            datos.Add("precio", producto.precio);
            datos.Add("stock", producto.stock);

            //Convert the data to a JSON string
            var jsonData = JsonConvert.SerializeObject(datos);

            Console.WriteLine("\n jsonData para Producto/AgregarProducto: " + jsonData);

            HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonData);

            Console.WriteLine("\n response Producto/AgregarProducto: " + response);

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
    }
}
