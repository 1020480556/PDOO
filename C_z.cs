using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class C_z
    {
        double c = 56.31 * Math.PI / 180;
        double z = 3;

        public void Operacion()
        {
            double t = z / Math.Sin(c);
            double y = z / Math.Tan(c);
            double a = (Math.Acos(z / t)) * 180 / Math.PI;
            Console.WriteLine(t);
            Console.WriteLine(y);
            Console.WriteLine(a);
        }
    }
}
