using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap9_12.Capitulo12
{
    public class Factorial
    {
        public Factorial()
        {

        }

        public static int factorial()
        {
            int num = 0, res = 1;
            Console.Write("Digite Numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
                return num;

            for (int i = 1; i <= num; ++i)
                res *= i;

            Console.WriteLine("El Factorial de {0} es {1} ", num, res);
            Console.WriteLine();
            return num;
        }
    }
}
