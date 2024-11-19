using System;
using System.Globalization;

namespace ex2_estrutura_sequencial{
    class Program{
        static void Main(string[] args){
            
            Console.WriteLine(new string('-',40));
            double raio = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = 3.14159 * (Math.Pow(raio,2));

            System.Console.WriteLine($"Área = {area.ToString("F4",CultureInfo.InvariantCulture)}");
            Console.WriteLine(new string('-',40));
        }
    }
}