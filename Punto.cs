using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7 {
    class Punto {
        Random aleatorio = new Random();
        public double x;
        public double y;

        public void Aleatorizar() {

            x = aleatorio.Next(-100, 101);
            y = aleatorio.Next(-100, 101);
        }
    }
}
