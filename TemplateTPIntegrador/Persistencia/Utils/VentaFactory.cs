using System;
using System.Collections.Generic;
using Datos;

namespace Persistencia.Utils
{
    public static class VentaFactory
    {
        private static Random _random = new Random();

        public static List<Venta> GenerarVentasRandom(int cantidad)
        {
            var ventas = new List<Venta>();

            for (int i = 0; i < cantidad; i++)
            {
                var venta = new Venta(
                    idCliente: Guid.NewGuid(),
                    idUsuario: Guid.NewGuid(),
                    idProducto: Guid.NewGuid(),
                    cantidad: _random.Next(1, 18)
                );

                ventas.Add(venta);
            }

            return ventas;
        }
    }
}

