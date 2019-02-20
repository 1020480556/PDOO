using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7 {
    class Triangulo {

        public Punto[] coordenadas;
        public double d1, d2, d3;
        public double pendiente1, pendiente2, pendiente3;
        bool triangulo = false;

        public void Validar() {
            if (coordenadas.Length == 4) {
                Console.WriteLine("Tiene 4 puntos");

                if (coordenadas[0].x == coordenadas[3].x && coordenadas[0].y == coordenadas[3].y) {
                    Console.WriteLine("Es figura cerrada");
                    pendiente1 = (coordenadas[1].y - coordenadas[0].y) / (coordenadas[1].x - coordenadas[0].x);
                    pendiente2 = (coordenadas[2].y - coordenadas[1].y) / (coordenadas[2].x - coordenadas[1].x);
                    pendiente3 = (coordenadas[3].y - coordenadas[2].y) / (coordenadas[3].x - coordenadas[2].x);

                    if (pendiente1 != pendiente2 && pendiente2 != pendiente3 && pendiente1 != pendiente3) {
                        Console.WriteLine("No son colineales");
                        Console.WriteLine("Es un triangulo");
                        triangulo = true;
                    }
                }
                    
            }
            else Console.WriteLine("no es triangulo");
        }

        public void Clasificar() {

            Validar();
            if (triangulo == true) {
                d1 = Math.Sqrt(Math.Pow((coordenadas[1].x - coordenadas[0].x), 2) - Math.Pow((coordenadas[1].y - coordenadas[0].y), 2));
                d2 = Math.Sqrt(Math.Pow((coordenadas[2].x - coordenadas[1].x), 2) - Math.Pow((coordenadas[2].y - coordenadas[1].y), 2));
                d3 = Math.Sqrt(Math.Pow((coordenadas[3].x - coordenadas[2].x), 2) - Math.Pow((coordenadas[3].y - coordenadas[2].y), 2));

                if (d1 == d2 && d2 == d3 && d3 == d1) Console.WriteLine("Triangulo equilatero");
                else if(d1 != d2 && d2 != d3 && d3 != d1) Console.WriteLine("Triangulo Escaleno");
                else Console.WriteLine ("Triangulo Isoceles");
            }
        }
    }
}
