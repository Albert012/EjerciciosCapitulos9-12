using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap9_12.Capitulo10
{
    /// <summary>
    /// Clase Poligono con Sobrecarga de Contructores
    /// </summary>
    public class PoligonoSobrecarga
    {
        public Double Apotema { get; set; }
        public Double Perimetro { get; set; }

        public PoligonoSobrecarga()
        {

        }

        public PoligonoSobrecarga(double apotema, double perimetro)
        {
            Apotema = apotema;
            Perimetro = perimetro;
        }
    }
}
