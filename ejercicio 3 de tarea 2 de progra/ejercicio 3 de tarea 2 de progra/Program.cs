using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3_de_tarea_2_de_progra
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalh, numhoras, horasextras,total;
            System.Console.WriteLine("Ingrese el numero de horas que ha trabajado: ");
            numhoras = Convert.ToInt32(Console.ReadLine());

            if (numhoras <=40)
            {
                totalh = numhoras * 16;
                Console.Write("Su sueldo en quetzales es de: " + totalh);
            }
            else
            {
                System.Console.WriteLine("Ingrese el numero de horas extras que ha trabajado: ");
                horasextras = Convert.ToInt32(Console.ReadLine());
                horasextras = 20;
                totalh = numhoras * 16;
                total = totalh + horasextras;
                Console.Write("Su sueldo en quetzales es de: " + total);

            }

            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();
        }
    }
}
