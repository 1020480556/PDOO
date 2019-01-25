using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioUsuario = 4000000;
            double aporte = salarioUsuario * 0.04; 
            double salariomin = 781242;
            bool condTb = salariomin * 2 < salarioUsuario && salarioUsuario < salariomin * 4;

            if (salariomin * 2 > salarioUsuario) Console.WriteLine("TA: " + aporte);
            else if (condTb) Console.WriteLine("TB:" + aporte);
            else if (salariomin * 4 < salarioUsuario) Console.WriteLine("TC: " + aporte);
        }
    }
}
