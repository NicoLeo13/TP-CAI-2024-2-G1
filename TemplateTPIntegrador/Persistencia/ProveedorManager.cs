﻿using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace Persistencia
{
    public class ProveedorManager
    {
        private const String adminId = "abc27a5f-7f7f-4f11-a244-475c8f0c0e89";
        private static void LoguearRequest(HttpResponseMessage response)
        {
            Console.WriteLine($"\nRequest efectuada: \n[\n {response.RequestMessage} \n\n {response.ReasonPhrase}  \n\n {response.StatusCode} \n]\n");
        }

        public List<Proveedor> TraerProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();

            HttpResponseMessage response = WebHelper.GetSinAdminId("Proveedor/TraerProveedores");

            LoguearRequest(response);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Proveedor> listadoProveedores = JsonConvert.DeserializeObject<List<Proveedor>>(contentStream);
                return listadoProveedores;
            }
            else
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                throw new HttpRequestException($"Error al momento de traer los proveedores: {(int)response.StatusCode} - {response.ReasonPhrase}");
            }
        }

        public static Proveedor TraerProveedor(string cuitProveedor)
        {

            ProveedorManager proveedorManager = new ProveedorManager();

            try
            {
                // Llama al método que trae todos los proveedores
                List<Proveedor> proveedores = proveedorManager.TraerProveedores();

                // Busca al proveedor puntual con LINQ
                var proveedorEncontrado = proveedores.FirstOrDefault(u => u.CUIT == cuitProveedor);

                if (proveedorEncontrado != null)
                {
                    Console.WriteLine($"\nProveedor encontrado: {proveedorEncontrado.Nombre} {proveedorEncontrado.Apellido} - {proveedorEncontrado.CUIT} - {proveedorEncontrado.Id}");
                    return proveedorEncontrado;
                }

            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError de red: {ex.Message}");
                throw new Exception($"Error de red al intentar traer el proveedor de CUIT: '{cuitProveedor}':\n{ex.Message}", ex);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"\nArgumento nulo: {ex.Message}");
                throw new Exception($"Argumento nulo al intentar traer el proveedor de CUIT: '{cuitProveedor}':\n{ex.Message}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError inesperado: {ex.Message}");
                throw new Exception($"Error inesperado al intentar traer el proveedor de CUIT: '{cuitProveedor}':\n{ex.Message}", ex);
            }

            return null;

        }

        public void EliminarProveedor(Proveedor proveedor)
        {
            Dictionary<String, object> datos = new Dictionary<String, object>();

            datos.Add("id", proveedor.Id);
            datos.Add("idUsuario", adminId);

            var jsonData = JsonConvert.SerializeObject(datos);

            HttpResponseMessage response = WebHelper.DeleteWithBody("Proveedor/BajaProveedor", jsonData);

            LoguearRequest(response);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"Error: {errorContent}");
                throw new HttpRequestException($"Error al eliminar el proveedor:\n{errorContent}");
            }
        }
    }
}