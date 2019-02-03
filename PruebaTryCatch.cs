using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese número de jugadores. entre 2 y 5");
            while (true)
            {               
                try
                {
                    int n = int.Parse(Console.ReadLine());

                    while (n < 2 || n > 5)
                    {
                        Console.WriteLine("Error. Ingrese número de jugadores");
                        n = int.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Error de formato, ingrese número de jugadores");
                }              
            }
            Console.WriteLine("Correcto");
        }
    }
}
