using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap9_12.Capitulo10
{
    /// <summary>
    /// Clase Poligono con propiedad que solamanente permita
    /// valores validos
    /// </summary>
    public class PoligonoPropiedad
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }

        public PoligonoPropiedad()
        {

        }

        public PoligonoPropiedad(double perimetro, double apotema)
        {
            Perimetro = perimetro;
            Apotema = apotema;
        }

        public double CalcularArea()
        {
            Perimetro = 20; Apotema = 4.25; 

            return Perimetro * Apotema / 2;
        }
    }
}
