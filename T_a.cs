using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class T_a
    {
        double a = 33.69 * Math.PI / 180;
        double t = 3.61;

        public void Operacion()
        {
            double y = Math.Sin(a) * t;
            double z = Math.Cos(a) * t;
            double c = (Math.Acos(y / t)) * 180 / Math.PI;
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(c);
        }
    }
}
