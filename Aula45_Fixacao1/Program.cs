using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Retangulo ret = new Retangulo();

            System.Console.WriteLine("Entre a largura e altura do retângulo: ");
            System.Console.Write("Largura: ");
            ret.largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Comprimento: ");
            ret.altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(new string('-',40));

            System.Console.WriteLine($"Área: {ret.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Perímetro: {ret.Perimetro().ToString("F2",CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Diagonal: {ret.Diagonal().ToString("F2",CultureInfo.InvariantCulture)}");
            
            Console.WriteLine(new string('-',40));
        }
    }
}