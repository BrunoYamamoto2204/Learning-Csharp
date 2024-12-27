using System;
using System.Globalization;
using Course;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            System.Console.WriteLine("\nEntre com as medidas do triângulo Y:");
            y.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            System.Console.WriteLine($"Área de triângulo X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Área de triângulo Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");


            if (areaX > areaY){
                System.Console.WriteLine($"Maior área: X");
            }
            else{
                System.Console.WriteLine($"Maior área: Y");
            }

            Console.WriteLine(new string('-',40));
        }
    }
}
