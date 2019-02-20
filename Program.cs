using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7 {
    class Program {
        static void Main(string[] args) {
            Punto[] puntos = new Punto[4];
            
            for (int i = 0; i < puntos.Length; i++) {
                puntos[i] = new Punto();
                puntos[i].x = double.Parse(Console.ReadLine());
                puntos[i].y = double.Parse(Console.ReadLine());
            }

            Triangulo triangulo = new Triangulo();
            triangulo.coordenadas = puntos;
            triangulo.Clasificar();
            
        }
    }
}
