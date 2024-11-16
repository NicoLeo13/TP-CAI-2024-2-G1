using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Persistencia.Utils
{
    public static class ProductoFactory
    {
        private static Random _random = new Random();
        private static string[] _adjetivos = { "Nuevo", "Innovador", "Samsung", "Calidad Precio", "Elegante", "China", "Barata", "LG" };
        private static string[] _sustantivos = { "Celular", "Dispositivo", "Reloj", "Freidora", "Producto" };

        public static List<Producto> GenerarProductosRandom(int cantidad)
        {
            var productos = new List<Producto>();

            for (int i = 0; i < cantidad; i++)
            {
                var producto = new Producto(
                    idCategoria: _random.Next(1, 5),
                    idUsuario: Guid.NewGuid(),
                    idProveedor: Guid.NewGuid(),
                    nombre: GenerarNombreProducto(),
                    precio: _random.Next(1000, 15000),
                    stock: _random.Next(1, 27),
                    fechaAlta: DateTime.Now,
                    fechaBaja: null
                );

                productos.Add(producto);
            }

            return productos;
        }

        public static string GenerarNombreProducto()
        {
            string adjetivo = _adjetivos[_random.Next(_adjetivos.Length)];
            string sustantivo = _sustantivos[_random.Next(_sustantivos.Length)];
            return $"{adjetivo} {sustantivo}";
        }
    }
}

