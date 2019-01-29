using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularVotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese votos de A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese votos de B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese votos en blanco:");
            int blancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese votos anulados:");
            int anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número total de la población de todas las edades:");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje (de 0 a 100%) de la población que es mayor de edad:");
            int p = int.Parse(Console.ReadLine());

            double votantesMayores = (n * p) / 100;
            int total = a + b + blancos + anulados;
            double dif = a - b;

            if (dif > 0) dif *= (-1);

            bool cond1 = (total > votantesMayores) || (dif < (n *= 0.10));
            bool cond2 = (total < (n *= 0.30));

            if (cond1 && cond2) Console.WriteLine("Repetir elecciones");

            else if (a > b) Console.WriteLine("Ganador A");
            else if (a < b) Console.WriteLine("Ganador B");
            else if (a == b) Console.WriteLine("Ganador B");
        }
    }
}
