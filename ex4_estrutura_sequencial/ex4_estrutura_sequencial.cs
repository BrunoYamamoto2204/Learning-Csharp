using System;
using System.Globalization;

namespace ex4_estrutura_sequencial{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            float valor = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            float salario = valor*horas;
            System.Console.WriteLine($"Number = {num}");
            System.Console.WriteLine($"Salary = U$ {salario.ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine(new string('-',40));
        }
    }
}