using Datos;
using Persistencia;
using System;

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
    }
}

//using Datos;
//using Persistencia;
//using System;
//using System.Threading.Tasks;

//namespace Negocio
//{
//    public class ProveedorService
//    {
//        public static async Task<Proveedor> BuscarProveedorAsync(string cuitProveedor)
//        {
//            try
//            {
//                return await ProveedorManager.TraerProveedorAsync(cuitProveedor);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"\nError al buscar el proveedor: {ex.Message}");
//                throw;
//            }
//        }
//    }
//}
