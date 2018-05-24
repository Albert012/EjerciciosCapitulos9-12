using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap9_12.Capitulo10
{
    /// <summary>
    /// Disenado una clase para llevar un inventario
    /// </summary>
    public class Inventario
    {
        public int ProductoId { get; set; }
        public double CostoUnidad { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
        public double Ganacias { get; set; }
        public double TotalGanancias { get; set; }

        public Inventario()
        {
            ProductoId = 0;
            CostoUnidad = 0;
            PrecioCompra = 0;
            PrecioVenta = 0;
            Ganacias = 0;
            TotalGanancias = 0;
        }
    }
}
