using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Produto p = new Produto();

            System.Console.WriteLine("Entre os dados do produto: ");
            System.Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            
            System.Console.Write("Preço: R$");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            System.Console.Write("Quantidade no estoque: ");
            p.Qntd = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            System.Console.WriteLine($"Dados do produto: {p}");
            System.Console.WriteLine($"Valor Total: R${p.ValorTotalEmEstoque()}");
            Console.WriteLine(new string('-',40));
        }
    }
}