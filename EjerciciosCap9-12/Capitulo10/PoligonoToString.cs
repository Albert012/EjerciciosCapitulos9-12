using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap9_12.Capitulo10
{
    /// <summary>
    /// Clase Poligono con metodo ToString();
    /// </summary>
    public class PoligonoToString
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }

        public PoligonoToString()
        {

        }

        public PoligonoToString(double perimetro, double apotema)
        {
            Perimetro = perimetro;
            Apotema = apotema;
        }

        public double CalcularArea()
        {
            Perimetro = 20; Apotema = 4.25;

            return Perimetro * Apotema / 2;
        }

        public static void menu()
        {
            PoligonoToString ps = new PoligonoToString();
            Console.WriteLine(ps.ToString());
        }
    }
}
