using System;
using System.Globalization;

namespace Teste{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            float ax,bx,cx,ay,by,cy,px,py;

            System.Console.WriteLine("Entre com as medidas do triângulo X:");
            ax = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bx = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cx = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            System.Console.WriteLine("\nEntre com as medidas do triângulo Y:");
            ay = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            by = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cy = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            px = (ax+bx+cx)/2;
            double areax = Math.Sqrt(px * (px- ax)*(px- bx)*(px- cx));
            System.Console.WriteLine($"Área de triângulo X: {areax.ToString("F4", CultureInfo.InvariantCulture)}");

            py = (ay+by+cy)/2;
            double areay = Math.Sqrt(py * (py- ay)*(py- by)*(py - cy));
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