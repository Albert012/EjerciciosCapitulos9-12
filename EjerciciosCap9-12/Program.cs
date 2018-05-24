using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            int opc = 0;

            do
            {
                Console.WriteLine(">> Bienvenidos a los ejercicios de los Capitulos 9-10-12 <<");
                //Console.WriteLine("\n1) Ejercicio #1 Cap 9 \n2) Ejercicio #3 Cap 9 \n3) Ejercicio #4 Cap 9 \n\n4) Ejercicio #1 Cap 10 \n5) Ejercicio #2 Cap 10 \n6) Ejercicio #3 Cap 10 \n7) Ejercicio #4 Cap 10 \n8) Ejercicio #5 Cap 10 \n\n9) Ejercicio #1 Cap 12 \n10) Ejercicio #2 Cap 12 \n12) Ejercicio #3 Cap 12 \n12) Ejercicio #4 Cap 12 \n13) Ejercicio #5 Cap 12");
                Console.WriteLine("\n1) Ejercicio #1 Cap 12");
                Console.Write("\nCual Desea Elegir: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch(opc)
                {
                    case 0:
                        break;
                    case 1:
                        Capitulo12.Factorial.factorial();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta!!");
                        break;                        
                }
            } while (opc != 0);
            Console.WriteLine();
            
        }
    }
}
