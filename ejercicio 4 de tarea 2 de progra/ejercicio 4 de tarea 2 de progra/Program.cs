using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_de_tarea_2_de_progra
{
    class Program
    {
        static void Main(string[] args)
        {

            int Diciembre = 12;
            int Febrero = 2;
          
            int diadic = DateTime.DaysInMonth(2008, Diciembre);

            Console.WriteLine(diadic);
          
            int diafebre = DateTime.DaysInMonth(2016, Febrero);

            Console.WriteLine(diafebre);

            int diafebre2 = DateTime.DaysInMonth(2018, Febrero);

            Console.WriteLine(diafebre2);

            Console.WriteLine("\n\nPresione < ENTER > para salir . . .");
            Console.ReadKey();

        }
    }
}
