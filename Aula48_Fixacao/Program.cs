using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            System.Console.Write("Cotação do dólar: $");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             
            System.Console.Write("Quandos dólares você vai comprar: $");
            double dolares = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double pagar = Moeda.ConversorDeMoeda(valor,dolares);
            System.Console.WriteLine($"Valor a ser pago: R${pagar.ToString("F2",CultureInfo.InvariantCulture)}");
            
            Console.WriteLine(new string('-',40));
        }
    }
}