using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_tarea_2_progra
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            bool esPrimo = true;
            System.Console.WriteLine("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine("Es primo");
            }

            else
            {
                Console.WriteLine("No es primo");
            }
            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();
        }
    }
}
