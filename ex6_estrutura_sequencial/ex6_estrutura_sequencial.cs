using System;
using System.Globalization;

namespace ex6_estrutura_sequencial{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            string[] lista = Console.ReadLine().Split();
            float a = float.Parse(lista[0],CultureInfo.InvariantCulture);
            float b = float.Parse(lista[1],CultureInfo.InvariantCulture);
            float c = float.Parse(lista[2],CultureInfo.InvariantCulture);

            float triangulo = (a*c)/2;
            double circulo =  3.14159*Math.Pow(c,2);
            float trapezio = ((a+b)*c)/2;
            float quadrado = b*b;
            float retangulo = a*b;
            
            System.Console.WriteLine($"triangulo = {triangulo.ToString("F3",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"circulo = {circulo.ToString("F3",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"trapezio = {trapezio.ToString("F3",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"quadrado = {quadrado.ToString("F3",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"retangulo = {retangulo.ToString("F3",CultureInfo.InvariantCulture)}");


            Console.WriteLine(new string('-',40));
        }
    }
}