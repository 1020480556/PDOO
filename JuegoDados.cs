using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {         
            Random aleatorio = new Random();           
            bool breakFor = false;
            Console.WriteLine("Ingrese número de jugadores");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (breakFor) break;
                int contador = 0;
                double contador2 = 0;
                int contadorTriples = 0;                
                Console.WriteLine("\nJugador" + (i + 1));
                int dado1 = aleatorio.Next(1, 10);
                int dado2 = aleatorio.Next(1, 10);
                int sumaDados = dado1 + dado2;
                Console.WriteLine("\ndado1: " + dado1);
                Console.WriteLine("dado2: " + dado2);
                Console.WriteLine("puntaje: " + sumaDados);
                contador++;
                if ((dado1 + dado2) > 6) contador2++;

                while (true)
                {
                    if (sumaDados >= 100)
                    {
                        Console.WriteLine("\nGanaste");
                        breakFor = true;
                        break;
                    }
                    if ((dado1 + dado2) == 2)
                    {
                        Console.WriteLine("\nperdiste");                       
                        break;
                    }
                    if (dado1 == dado2)
                    {
                        contadorTriples++;
                        if (contadorTriples == 3)
                        {
                            Console.WriteLine("\nGanaste por triple");
                            breakFor = true;
                            break;
                        }
                    }
                    else contadorTriples = 0;

                    Console.WriteLine("\ndesea otra carta? (s/n)");
                    if (Console.ReadLine() == "n") break;
                    dado1 = aleatorio.Next(1, 10);
                    dado2 = aleatorio.Next(1, 10);
                    sumaDados += dado1 + dado2;
                    Console.WriteLine("\ndado1: " + dado1);
                    Console.WriteLine("dado2: " + dado2);
                    Console.WriteLine("puntaje: " + sumaDados);
                    contador++;
                    if ((dado1 + dado2) > 6) contador2++;
                }
                double porcentaje = (contador2 / contador) *  100;
                Console.WriteLine("\nporcentaje: " + porcentaje);
                Console.WriteLine("\nFin de turno");
            }
            Console.WriteLine("Fin de partida");
        }
    }
}
