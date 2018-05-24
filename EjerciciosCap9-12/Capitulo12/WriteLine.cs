using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap9_12.Capitulo12
{
    public class WriteLine
    {
        public WriteLine()
        {

        }

        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                Console.WriteLine(fact);
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
            Console.ReadKey();

        }
    }
}
