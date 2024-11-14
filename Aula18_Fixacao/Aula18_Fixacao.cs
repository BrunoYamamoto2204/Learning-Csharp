using System;
using System.Globalization;

namespace Aula18_Fixacao{
    class Program{
        static void Main(string[] args){

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 520;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine(new string('-',60));
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2.ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero:{genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine(new string('-',60));
        }
    }
}
