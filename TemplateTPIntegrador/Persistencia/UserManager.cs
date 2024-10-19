using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UserManager
    {
        private String adminId = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        //{
        //  "idUsuario": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        //  "host": 1,
        //  "nombre": "string",
        //  "apellido": "string",
        //  "dni": 0,
        //  "direccion": "string",
        //  "telefono": "string",
        //  "email": "string",
        //  "fechaNacimiento": "2024-10-11T23:03:44.576Z",
        //  "nombreUsuario": "string",
        //  "contraseña": "string"
        //}



        public String AgregarUsuario(UsuarioLocal usuarioLocal)
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


            // Otra forma de agregar data que no era con datos.Add

            //{
            //    { "idUsuario", usuarioLocal.IdUsuario },
            //    { "host", usuarioLocal.Host },
            //    { "nombre", usuarioLocal.Nombre },
            //    { "apellido", usuarioLocal.Apellido },
            //    { "dni", usuarioLocal.Dni },
            //    { "direccion", usuarioLocal.Direccion },
            //    { "telefono", usuarioLocal.Telefono },
            //    { "email", usuarioLocal.Email },
            //    { "fechaNacimiento", usuarioLocal.FechaNacimiento },
            //    { "nombreUsuario", usuarioLocal.NombreUsuario },
            //    { "contraseña", usuarioLocal.Contraseña }
            //};


            var jsonData = JsonConvert.SerializeObject(datos);

            Debug.WriteLine("jsonData Usuario/AgregarUsuario: " + jsonData);

            // Ejemplo Swagger:

            // curl -X POST "https://cai-tp.azurewebsites.net/api/Usuario/AgregarUsuario" -H  "accept: */*" -H  "Content-Type: application/json" -d
            // "{\"idUsuario\":\"70b37dc1-8fde-4840-be47-9ababd0ee7e5\",\"host\":3,\"nombre\":\"JohnS\",\"apellido\":\"DoeS\",
            // \"dni\":11222333,\"direccion\":\"test S 123\",\"telefono\":\"11 22443355\",\"email\":\"testS@test.com\",
            // \"fechaNacimiento\":\"2024-10-12T00:12:17.080Z\",\"nombreUsuario\":\"johndoe9\",\"contraseña\":\"UbaFce2024!\"}"

            //{
            //      "idUsuario": "70b37dc1-8fde-4840-be47-9ababd0ee7e5",
            //      "host": 3,
            //      "nombre": "JohnS",
            //      "apellido": "DoeS",
            //      "dni": 11222333,
            //      "direccion": "test S 123",
            //      "telefono": "11 22443355",
            //      "email": "testS@test.com",
            //      "fechaNacimiento": "2024-10-12T00:12:17.080Z",
            //      "nombreUsuario": "johndoe9",
            //      "contraseña": "UbaFce2024!"
            //}


            // Lo que estoy enviando:

            //{
            //    "idUsuario": "70b37dc1-8fde-4840-be47-9ababd0ee7e5",
            //    "host": 3,
            //    "nombre": "John",     // Capaz era muy corto
            //    "apellido": "Doe",    // Capaz era muy corto v2
            //    "dni": 13222548,
            //    "direccion": "test 123",
            //    "telefono": "11 22334445",
            //    "email": "tes45t@test.com",
            //    "fechaNacimiento": "2024-10-02T21:57:30",     // la fecha tenía el quilombo
            //    "nombreUsuario": "johndoe1",
            //    "contraseña": "UbaFce2024!"
            //}

            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonData);

            Debug.WriteLine("response Usuario/AgregarUsuario: " + response);

            String result;

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                result = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Debug.WriteLine($"Error: {errorContent}");
                throw new Exception("Error al crear el nuevo usuario.");
            }

            return result;
        }

        public List<UsuarioWS> TraerUsuariosActivos()
        {
            List<UsuarioWS> clientes = new List<UsuarioWS>();

            HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + adminId);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<UsuarioWS> listadoUsuariosActivos = JsonConvert.DeserializeObject<List<UsuarioWS>>(contentStream);
                return listadoUsuariosActivos;
            }
            else
            {
                Debug.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento de buscar los usuarios");
            }

        }
    }
}
