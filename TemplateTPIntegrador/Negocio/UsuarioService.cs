using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Negocio
{
    public class UsuarioService
    {
        private readonly UserManager _userManager;
        private DateTime fechaAlta = DateTime.Now;

        public UsuarioService()
        {
            _userManager = new UserManager();
        }

        public async Task<(List<UsuarioWS> usuariosActivos, string msg)> CargarUsuariosActivosAsync()
        {
            try
            {
                return await _userManager.TraerUsuariosActivosAsync();
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        public static UsuarioWS BuscarUsuario(string nombreUsuario)
        {
            try
            {
                return UserManager.TraerUsuario(nombreUsuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al buscar usuario: {ex.Message}");
                throw;
            }
        }

        public void AgregarUsuario(Guid idUsuario, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, int host, int dni, string contraseña, DateTime? fechaAlta = null, DateTime? fechaBaja = null)
        /*Uso de parámetros opcionales para las fechas de alta y baja. Hago los campos nullable para poder asignarles valores por defecto en caso de que no se proporcionen*/
        {
            //Preguntar si esta bien que haya que usar admin o hay un error
            const string adminId = "abc27a5f-7f7f-4f11-a244-475c8f0c0e89";
            Guid adminGuid = Guid.Parse(adminId);

            try
            {
                UsuarioLocal usuarioLocal = new UsuarioLocal(adminGuid, nombre, apellido, direccion, telefono, email, fechaAlta?? DateTime.Now, fechaNacimiento, fechaBaja?? DateTime.MinValue, nombreUsuario, host, dni, contraseña);
                /*Uso operadores ternarios para asignar la fecha actual si no se proporciona una fecha de alta y la fecha mínima si no se proporciona una fecha de baja. Coallesce operator para asignar valores por defecto*/

                //Castear el usuario a un usuarioWS
                UsuarioWS usuarioWS = new UsuarioWS(adminGuid, usuarioLocal.Nombre, usuarioLocal.Apellido, usuarioLocal.Dni, usuarioLocal.NombreUsuario, usuarioLocal.Host);

                // Lógica de negocio para agregar un usuario
                // Validaciones, transformaciones, etc.
                // Llamada a la capa de persistencia para guardar el usuario

                UserManager persistencia = new UserManager();
                persistencia.AgregarUsuario(usuarioLocal);
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



        //public string AgregarUsuario(UsuarioLocal usuarioLocal)
        //{
        //    // Lógica de negocio para agregar un usuario
        //    // Validaciones, transformaciones, etc.
        //    // Llamada a la capa de persistencia para guardar el usuario

        //    Persistencia.UserManager persistencia = new Persistencia.UserManager();
        //    return persistencia.AgregarUsuario2(usuarioLocal);
        //}


        public string ModificarUsuario(UsuarioLocal usuarioLocal)
        {
            // Lógica de negocio para agregar un usuario
            // Validaciones, transformaciones, etc.
            // Llamar a la capa de persistencia para actualizar el usuario
            UserManager persistencia = new UserManager();
            //return persistencia.ModificarUsuario(usuarioLocal);
            return "No implementado";
        }


        public void EliminarUsuario(UsuarioWS usuario)
        {
            // Lógica de negocio para agregar un usuario
            // Validaciones, transformaciones, etc.
            // Llamar a la capa de persistencia para eliminar el usuario
            try
            {
                UserManager persistencia = new UserManager();
                persistencia.EliminarUsuario(usuario);
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
