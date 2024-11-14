using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class ClienteService
    {
        public async Task<Cliente> BuscarCliente(int dni)
        {
            ClienteWS persistencia = new ClienteWS();
            return await persistencia.BuscarCliente(dni);
        }
        public async Task EliminarCliente(int idCliente)
        {
            try
            {
                ClienteWS persistencia = new ClienteWS();
                await persistencia.EliminarCliente(idCliente);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError de WS: {ex.ToString()}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError Inesperado: {ex.ToString()}");
                throw;
            }

            //return "No implementado";
        }
    }
}
