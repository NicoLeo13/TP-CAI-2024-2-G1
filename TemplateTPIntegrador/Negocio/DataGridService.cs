using Datos;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace Negocio
{
    public class DataGridService
    {
        private bool sortAscending = true;
        private string sortedColumn = null;

        public List<UsuarioWS> FiltrarUsuarios(List<UsuarioWS> usuarios, string campo, string valor)
        {
            // Establece por qué campo filtrar y qué valor buscar
            switch (campo)
            {
                case "Nombre":
                    return usuarios.Where(u => u.Nombre.ToLower().Contains(valor.ToLower())).ToList();
                case "Apellido":
                    return usuarios.Where(u => u.Apellido.ToLower().Contains(valor.ToLower())).ToList();
                case "Dni":
                    return usuarios.Where(u => u.Dni.ToString().Contains(valor)).ToList();
                case "NombreUsuario":
                    return usuarios.Where(u => u.NombreUsuario.ToLower().Contains(valor.ToLower())).ToList();
                case "Id":
                    return usuarios.Where(u => u.Id.ToString().Contains(valor)).ToList();
                case "Host":
                    return usuarios.Where(u => u.Host.ToString().Contains(valor)).ToList();
                default:
                    return usuarios;
            }
        }

        public List<UsuarioWS> OrdenarUsuarios(List<UsuarioWS> usuarios, string column, bool ascending)
        {
            if (column != sortedColumn)
                sortAscending = true;

            List <UsuarioWS> usuariosOrdenados = ascending ? usuarios.OrderBy(u => u.GetType().GetProperty(column).GetValue(u, null)).ToList() : usuarios.OrderByDescending(u => u.GetType().GetProperty(column).GetValue(u, null)).ToList();

            sortAscending = !sortAscending;
            sortedColumn = column;

            return usuariosOrdenados;
        }
    }
}
