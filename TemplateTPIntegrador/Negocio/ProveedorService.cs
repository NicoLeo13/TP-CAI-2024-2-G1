using Datos;
using Persistencia;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Negocio
{
    public class ProveedorService
    {
        public static Proveedor BuscarProveedor(string cuitProveedor)
        {
            try
            {
                return ProveedorManager.TraerProveedor(cuitProveedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al buscar el proveedor: {ex.Message}");
                throw;
            }
        }

        public void EliminarProveedor(Proveedor proveedor)
        {
            try
            {
                ProveedorManager persistencia = new ProveedorManager();
                persistencia.EliminarProveedor(proveedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al buscar el proveedor: {ex.Message}");
                throw;
            }
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            try
            {
                ProveedorManager persistencia = new ProveedorManager();
                persistencia.ModificarProveedor(proveedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al buscar el proveedor: {ex.Message}");
                throw;
            }
        }

        public void AgregarProveedor(Proveedor proveedor)
        {
            try
            {
                ProveedorManager persistencia = new ProveedorManager();
                persistencia.AgregarProveedor(proveedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al buscar el proveedor: {ex.Message}");
                throw;
            }
        }
    }
}
