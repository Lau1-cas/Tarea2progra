using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_tarea_2_prograa
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;

            Console.WriteLine("Ingrese el dia de la semana");
            dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Dia laboral. Feliz inicio de semana");
                    break;
                case "martes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("Dia laboral");
                    break;
                case "Jueves":
                    Console.WriteLine("Dia laboral");
                    break;
                case "viernes":
                    Console.WriteLine("Ultimo dia laboral de la semana");
                    break;
                default:
                    Console.WriteLine("Dia no laboral");
                    break;

    }
            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();



        }
    }
}
