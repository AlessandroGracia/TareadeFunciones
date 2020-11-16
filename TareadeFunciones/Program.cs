using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaWhile1
{
    class Program
    {
        // Preparar un ejercicio que obtenga una funcion y un condicional dentro
        static void Main(string[] args)
        {
            Console.WriteLine("Los numeros son: ");
            int x;
            x = 1;
            while (x <= 100)
            {
                Console.Write(x);
                Console.Write(" - ");
                x = x + 1;
            }
            Console.ReadKey();
        }
        
    }
}
