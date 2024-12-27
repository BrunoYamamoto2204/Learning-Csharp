using System;
using System.Globalization;
using Course;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Triangulo x,y;

            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            System.Console.WriteLine("\nEntre com as medidas do triângulo Y:");
            y.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double px = (x.A+x.B+x.C)/2;
            double areax = Math.Sqrt(px * (px - x.A)*(px- x.B)*(px- x.C));
            System.Console.WriteLine($"Área de triângulo X: {areax.ToString("F4", CultureInfo.InvariantCulture)}");

            double py = (y.A+y.B+y.C)/2;
            double areay = Math.Sqrt(py * (py- y.A)*(py- y.B)*(py - y.C));
            System.Console.WriteLine($"Área de triângulo Y: {areay.ToString("F4", CultureInfo.InvariantCulture)}");


            if (px > py){
                System.Console.WriteLine($"Maior área: X");
            }
            else{
                System.Console.WriteLine($"Maior área: Y");
            }

            Console.WriteLine(new string('-',40));
        }
    }
}
