﻿using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;

namespace Persistencia
{
    public class LoginWS
    {
        public (String idUsuario, string responseBody, string statusCode) login(String username, String password)
        {
            string idUsuario = "";
            string responseBody = "";

            Dictionary<String, String> datos = new Dictionary<String, String>();

            datos.Add("nombreUsuario", username);
            datos.Add("contraseña", password);

            // Convert the data to a JSON string
            var jsonData = JsonConvert.SerializeObject(datos);

            Console.WriteLine("\njsonData para Usuario/Login: " + jsonData);

            HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonData);

            Console.WriteLine("\nresponse Usuario/Login: " + response);

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                idUsuario = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
            }
            else
            {
                responseBody = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"\nBody de la respuesta: {responseBody}");
                throw new Exception($"Error: {responseBody}");
            }

            return (idUsuario, responseBody, ((int)response.StatusCode).ToString());
        }

    }
}
