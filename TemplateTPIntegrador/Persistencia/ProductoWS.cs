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
        public static void LoguearRequest(HttpResponseMessage response)
        {
            Console.WriteLine($"\nRequest efectuada: \n[\n {response.RequestMessage} \n\n {response.ReasonPhrase}  \n\n {response.StatusCode} \n]\n");
        }

        public string AgregarProducto(Producto producto)
        {
            //string idUsuario = "";
            //string responseBody = "";

            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("idCategoria", producto.IdCategoria);
            datos.Add("idUsuario", producto.IdUsuario);
            datos.Add("idProveedor", producto.IdProveedor);
            datos.Add("nombre", producto.Nombre);
            datos.Add("precio", producto.Precio);
            datos.Add("stock", producto.Stock);

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

        public List<Producto> TraerProductos()
        {
            HttpResponseMessage response = WebHelper.GetSinAdminId("Producto/TraerProductos");

            LoguearRequest(response);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Producto> listadoProductos = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                return listadoProductos;
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                throw new HttpRequestException($"Error al momento de traer los productos: {(int)response.StatusCode} - {response.ReasonPhrase}");
            }
        }


        public static Producto TraerProducto(string nombre)
        {
            ProductoWS productoWS = new ProductoWS();

            try
            {
                // Llama al método que trae el producto
                List<Producto> producto = productoWS.TraerProductos();

                // Busca el producto por nombre
                var productoencontrado = producto.FirstOrDefault(u => u.Nombre == nombre);

                if (productoencontrado != null)
                {
                    Console.WriteLine($"\nProducto encontrado: {productoencontrado.Nombre} {productoencontrado.IdCategoria} - {productoencontrado.Precio}");
                    return productoencontrado;
                }
                else
                {
                    Console.WriteLine($"\nProducto no encontrado.");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError de red: {ex.Message}");
                throw new Exception($"Error de red al intentar traer el prodcucto: '{nombre}':\n{ex.Message}", ex);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"\nArgumento nulo: {ex.Message}");
                throw new Exception($"Argumento nulo al intentar traer el producto: '{nombre}':\n{ex.Message}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError inesperado: {ex.Message}");
                throw new Exception($"Error inesperado al intentar traer el producto: '{nombre}':\n{ex.Message}", ex);
            }

            return null;

        }



        public void EliminarProducto(Producto producto)
        {
            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("nombre", producto.Nombre);

            var jsonData = JsonConvert.SerializeObject(datos);

            HttpResponseMessage response = WebHelper.DeleteWithBody("Producto/BajaProducto", jsonData);

            LoguearRequest(response);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new HttpRequestException($"Error al eliminar el producto:\n{errorContent}");
            }
        }
    }


}
