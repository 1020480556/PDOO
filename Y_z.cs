using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Y_z
    {
        double y = 2;
        double z = 3;

        public void Operacion()
        {
            double t = Math.Sqrt(y * y + z * z); 
            double a = (Math.Atan(z / y)) * 180 / Math.PI;
            double c = (Math.Atan(y / z)) * 180 / Math.PI;
            Console.WriteLine(t);
            Console.WriteLine(a);
            Console.WriteLine(c);
        }
    }
}
