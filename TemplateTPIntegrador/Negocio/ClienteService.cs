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
        public static Cliente BuscarCliente(int dniCliente)
        {
            try
            {
                return ClienteWS.TraerCliente(dniCliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al buscar usuario: {ex.Message}");
                throw;
            }
        }

        public void CrearCliente(Guid id, string nombre, int dni, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento, string host, DateTime? fechaAlta = null, DateTime? fechaBaja = null)
        {
            try
            {
                Cliente cliente = new Cliente(id, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, fechaAlta, fechaBaja, host);

                ClienteWS persistencia = new ClienteWS();

                persistencia.AgregarCliente(cliente);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError del WS: {ex.ToString()}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError inesperado: {ex.ToString()}");
                throw;
            }
        }

        public void ModificarCliente(Guid id, string direccion, string telefono, string email)
        {
            try
            {
                ClienteWS persistencia = new ClienteWS();

                persistencia.ModificarCliente(id, direccion, telefono, email);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nError del WS: {ex.ToString()}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError inesperado: {ex.ToString()}");
                throw;
            }
        }

        public void EliminarCliente(Guid idClienteAEliminar)
        {
            try
            {
                ClienteWS persistencia = new ClienteWS();
                persistencia.BajaCliente(idClienteAEliminar);
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
        }

        public void ReactivarCliente(Guid idClienteReactivar)
        {
            try
            {
                ClienteWS persistencia = new ClienteWS();
                persistencia.ReactivarCliente(idClienteReactivar);
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

        }
    }
}
