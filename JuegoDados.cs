using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int contador = 0;
            int contador2 = 0;
            int contadorTriples = 0;

            int n = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Jugador" + (i +1));
                int dado1 = aleatorio.Next(0, 10);
                int dado2 = aleatorio.Next(0, 10);
                int sumaDados = dado1 + dado2;
                Console.WriteLine("dado1: " + dado1);
                Console.WriteLine("dado2: " + dado2);
                Console.WriteLine("puntaje: " + sumaDados);

                while (true)
                {            
                    if (sumaDados >= 100)
                    {
                        Console.WriteLine("Ganadaste)");
                        break;
                    }
                    if ((dado1 + dado2) == 2)
                    {
                        Console.WriteLine("perdiste");
                        break;
                    }
                    if (dado1 == dado2)
                    {
                        contadorTriples++;
                        if (contadorTriples == 3)
                        {
                            Console.WriteLine("Ganaste por triple");
                            break;
                        }
                    }
                    else contadorTriples = 0;

                    Console.WriteLine("desea otra carta? (s/n)");

                    if (Console.ReadLine() == "n") break;
                    dado1 = aleatorio.Next(0, 10);
                    dado2 = aleatorio.Next(0, 10);
                    sumaDados += dado1 + dado2;
                    Console.WriteLine("dado1: " + dado1);
                    Console.WriteLine("dado2: " + dado2);
                    Console.WriteLine("puntaje: " + sumaDados);
                    contador++;
                    if ((dado1 + dado2) > 6) contador2++;
                }
                int porcentaje = (contador2 / contador) * 100;
                Console.WriteLine("porcentaje: " + porcentaje);

            }
        }
    }
}
