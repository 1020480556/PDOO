using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_cuota_moderadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar salario");
            double salarioUsuario = double.Parse(Console.ReadLine());
            double eps = salarioUsuario * 0.04;
            double salariomin = 781242;
            bool condTb = salariomin * 2 < salarioUsuario && salarioUsuario < salariomin * 5;

            if (salariomin * 2 > salarioUsuario) Console.WriteLine("TA: " + "$" + 3200 + " aporte EPS: " + eps);
            else if (condTb) Console.WriteLine("TA: " + 12700 + " aporte EPS: " + "$" + eps);
            else if (salariomin * 5 < salarioUsuario) Console.WriteLine("TA: " + "$" + 33500 + " aporte EPS: " + eps);
        }
    }
}
