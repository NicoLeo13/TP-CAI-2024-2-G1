using Datos;
using System;
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
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar usuarios: {ex.Message}");
                return usuarios;
            }
        }

        public List<UsuarioWS> OrdenarUsuarios(List<UsuarioWS> usuarios, string column, bool ascending)
        {
            try
            {
                if (column != sortedColumn)
                    sortAscending = true;

                List <UsuarioWS> usuariosOrdenados = ascending ? usuarios.OrderBy(u => u.GetType().GetProperty(column).GetValue(u, null)).ToList() : usuarios.OrderByDescending(u => u.GetType().GetProperty(column).GetValue(u, null)).ToList();

                sortAscending = !sortAscending;
                sortedColumn = column;

                return usuariosOrdenados;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar usuarios: {ex.Message}");
                return usuarios;
            }
        }

        public List<ItemCarrito> OrdenarCarrito(List<ItemCarrito> items, string column, bool ascending)
        {
            try
            {
                if (column != sortedColumn)
                    sortAscending = true;

                List<ItemCarrito> itemsOrdenados = ascending ? items.OrderBy(i => i.GetType().GetProperty(column).GetValue(i, null)).ToList() : items.OrderByDescending(i => i.GetType().GetProperty(column).GetValue(i, null)).ToList();

                sortAscending = !sortAscending;
                sortedColumn = column;

                return itemsOrdenados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar carrito: {ex.Message}");
                return items;
            }
        }

        public List<Producto> OrdenarProductos(List<Producto> productos, string column, bool ascending)
        {
            try
            {
                if (column != sortedColumn)
                    sortAscending = true;

                List<Producto> productosOrdenados = ascending ? productos.OrderBy(p => p.GetType().GetProperty(column).GetValue(p, null)).ToList() : productos.OrderByDescending(p => p.GetType().GetProperty(column).GetValue(p, null)).ToList();

                sortAscending = !sortAscending;
                sortedColumn = column;

                return productosOrdenados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar productos: {ex.Message}");
                return productos;
            }
        }

        public List<Producto> FiltrarProductos(List<Producto> productos, string campo, string valor)
        {
            try
            {
                switch (campo)
                {
                    case "Nombre":
                        return productos.Where(p => p.Nombre.ToLower().Contains(valor.ToLower())).ToList();
                    case "IdCategoria":
                        return productos.Where(p => p.IdCategoria.ToString().Contains(valor)).ToList();
                    case "Precio":
                        return productos.Where(p => p.Precio.ToString().Contains(valor)).ToList();
                    case "Stock":
                        return productos.Where(p => p.Stock.ToString().Contains(valor)).ToList();
                    case "FechaAlta":
                        return productos.Where(p => p.FechaAlta.ToString().Contains(valor)).ToList();
                    case "FechaBaja":
                        return productos.Where(p => p.FechaBaja.ToString().Contains(valor)).ToList();
                    default:
                        return productos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar productos: {ex.Message}");
                return productos;
            }
        }

        public List<Proveedor> OrdenarProveedores(List<Proveedor> proveedores, string column, bool ascending)
        {
            try
            {
                if (column != sortedColumn)
                    sortAscending = true;

                List<Proveedor> proveedoresOrdenados = ascending ? proveedores.OrderBy(p => p.GetType().GetProperty(column).GetValue(p, null)).ToList() : proveedores.OrderByDescending(p => p.GetType().GetProperty(column).GetValue(p, null)).ToList();

                sortAscending = !sortAscending;
                sortedColumn = column;

                return proveedoresOrdenados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar proveedores: {ex.Message}");
                return proveedores;
            }
        }

        public List<Proveedor> FiltrarProveedores(List<Proveedor> proveedores, string campo, string valor)
        {
            try
            {
                switch (campo)
                {
                    case "Nombre":
                        return proveedores.Where(p => p.Nombre.ToLower().Contains(valor.ToLower())).ToList();
                    case "Apellido":
                        return proveedores.Where(p => p.Apellido.ToLower().Contains(valor.ToLower())).ToList();
                    case "Email":
                        return proveedores.Where(p => p.Email.ToLower().Contains(valor.ToLower())).ToList();
                    case "CUIT":
                        return proveedores.Where(p => p.CUIT.ToString().Contains(valor)).ToList();
                    case "FechaAlta":
                        return proveedores.Where(p => p.FechaAlta.ToString().Contains(valor)).ToList();
                    case "FechaBaja":
                        return proveedores.Where(p => p.FechaBaja.ToString().Contains(valor)).ToList();
                    default:
                        return proveedores;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar proveedores: {ex.Message}");
                return proveedores;
            }
        }

        public List<Cliente> OrdenarClientes(List<Cliente> clientes, string column, bool ascending)
        {
            try
            {
                if (column != sortedColumn)
                    sortAscending = true;

                List<Cliente> clientesOrdenados = ascending ? clientes.OrderBy(c => c.GetType().GetProperty(column).GetValue(c, null)).ToList() : clientes.OrderByDescending(c => c.GetType().GetProperty(column).GetValue(c, null)).ToList();

                sortAscending = !sortAscending;
                sortedColumn = column;

                return clientesOrdenados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar clientes: {ex.Message}");
                return clientes;
            }
        }

        public List<Cliente> FiltrarClientes(List<Cliente> clientes, string campo, string valor)
        {
            try
            {
                switch (campo)
                {
                    case "Nombre":
                        return clientes.Where(c => c.Nombre.ToLower().Contains(valor.ToLower())).ToList();
                    case "Apellido":
                        return clientes.Where(c => c.Apellido.ToLower().Contains(valor.ToLower())).ToList();
                    case "Dni":
                        return clientes.Where(c => c.Dni.ToString().Contains(valor)).ToList();
                    case "Email":
                        return clientes.Where(c => c.Email.ToLower().Contains(valor.ToLower())).ToList();
                    case "Host":
                        return clientes.Where(c => c.Host.ToString().Contains(valor)).ToList();
                    case "FechaAlta":
                        return clientes.Where(c => c.FechaAlta.ToString().Contains(valor)).ToList();
                    default:
                        return clientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar clientes: {ex.Message}");
                return clientes;
            }
        }

    }
}
