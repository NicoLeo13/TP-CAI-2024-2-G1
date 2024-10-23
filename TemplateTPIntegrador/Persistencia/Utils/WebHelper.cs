using Persistencia.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Utils
{
    public class WebHelper
    {
        static HttpClient httpClient = new HttpClient();
        private static String rutaBase = "https://cai-tp.azurewebsites.net/api/";
        private static String adminId = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public static HttpResponseMessage Get(string url)
        {
            var uri = rutaBase + url + adminId;

            HttpResponseMessage response = httpClient.GetAsync(uri).Result;  // Blocking call!

            return response;
        }

        public static async Task<HttpResponseMessage> GetAsync(string url)
        {
            var uri = rutaBase + url + adminId;

            HttpResponseMessage response = await httpClient.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
                throw new HttpResponseMessageException(response);
            return response;
        }

        public static HttpResponseMessage Post(string url, string jsonRequest)
        {
            var uri = rutaBase + url;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = httpClient.PostAsync(uri, data).Result;
            string statusCode = ((int)response.StatusCode).ToString();

            return response;

        }

        public static async Task<HttpResponseMessage> PostAsync(string url, string jsonRequest)
        {
            var uri = rutaBase + url;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(uri, data);
            string statusCode = ((int)response.StatusCode).ToString();

            return response;

        }

        public static HttpResponseMessage Put(string url, string jsonRequest)
        {
            var uri = rutaBase + url + adminId;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = httpClient.PutAsync(uri, data).Result;

            return response;

        }

        public static async Task<HttpResponseMessage> PutAsync(string url, string jsonRequest)
        {
            var uri = rutaBase + url + adminId;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PutAsync(uri, data);

            return response;

        }

        public static HttpResponseMessage Patch(string url, string jsonRequest)
        {
            var uri = rutaBase + url + adminId;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            var request =
                new HttpRequestMessage(new HttpMethod("PATCH"), uri)
                {
                    Content = data
                };

            HttpResponseMessage response = httpClient.SendAsync(request).Result;

            return response;
        }

        public static async Task<HttpResponseMessage> PatchAsync(string url, string jsonRequest)
        {
            var uri = rutaBase + url + adminId;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            var request =
                new HttpRequestMessage(new HttpMethod("PATCH"), uri)
                {
                    Content = data
                };

            HttpResponseMessage response = await httpClient.SendAsync(request);

            return response;
        }

        public static HttpResponseMessage Delete(string url)
        {
            var uri = rutaBase + url + adminId;

            HttpResponseMessage response = httpClient.DeleteAsync(uri).Result;

            return response;
        }

        public static async Task<HttpResponseMessage> DeleteAsync(string url)
        {
            var uri = rutaBase + url + adminId;

            HttpResponseMessage response = await httpClient.DeleteAsync(uri);

            return response;
        }

        public static HttpResponseMessage DeleteWithBody(string url, string jsonRequest)
        {
            var uri = rutaBase + url + adminId;

            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(uri),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = httpClient.SendAsync(request).Result;

            return response;
        }

        public static async Task<HttpResponseMessage> DeleteWithBodyAsync(string url, string jsonRequest)
        {
            var uri = rutaBase + url + adminId;

            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(uri),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return response;
        }
    }
}
