using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese a, b y c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine()); ;
        double c = double.Parse(Console.ReadLine()); ;

        double dis = (b * b) - (4 * a * c);
        double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
        double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
       
        if (2 * a == 0) Console.WriteLine ("división por cero");
        
        else if (dis == 0) Console.WriteLine("Única solución");
        else if (dis > 0) Console.WriteLine("Dos posibles soluciones");
        else if (dis < 0) Console.WriteLine("No es posible calcular raiz cuadrada a un número negativo");

        Console.WriteLine("x1: " + x1);
        Console.WriteLine("x2: " + x2);

    }
}

