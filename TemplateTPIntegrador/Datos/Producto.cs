﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        private int _idCategoria;
        private Guid _idUsuario;
        private Guid _idProveedor;
        private string _nombre;
        private int _precio;
        private int _stock;

        public int idCategoria { get { return _idCategoria; } set { _idCategoria = value; } }
        public Guid idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public Guid idProveedor { get { return _idProveedor; } set { _idProveedor = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public int precio { get { return _precio; } set { _precio = value; } }
        public int stock { get { return _stock; } set { _stock = value; } }

        public Producto(int idCategoria, Guid idUsuario, Guid idProveedor, string nombre, int precio, int stock)
        {
            this.idCategoria = idCategoria;
            this.idUsuario = idUsuario;
            this.idProveedor = idProveedor;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
