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
            int a = aleatorio.Next(0, 10);
            int b = aleatorio.Next(0, 10);
            int sumaCorrecta = a + b;
            int contador = 0;
            Console.WriteLine("Eres un humano ?");
            Console.WriteLine("Ingresa el resultado de la siguiente suma");
            Console.WriteLine(a + " + " + b + ": ");
            int resp = int.Parse(Console.ReadLine());
            Console.WriteLine("resp: " + resp);
            Console.WriteLine("suma: " + sumaCorrecta);

            while (resp != sumaCorrecta)
            {
                contador++;
                if (contador >= 3) {
                    Console.WriteLine("Bloqueado");
                    break;
                }
                a = aleatorio.Next(0, 10);
                b = aleatorio.Next(0, 10);
                sumaCorrecta = a + b;
                Console.WriteLine("Respuesta incorrecta. ingrese la suma");
                Console.WriteLine(a + " + " + b + ": ");
                resp = int.Parse(Console.ReadLine());
            } 
            if (contador >= 3) Console.WriteLine("Ingreso denegado");
            else Console.WriteLine("Ingreso correcto");
        }
    }
}
