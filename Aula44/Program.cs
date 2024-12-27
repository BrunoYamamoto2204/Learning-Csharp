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
            p.Qntd = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"\nDados do produto: {p}\n");

            //Adicionar 
            System.Console.Write("Digite a quantidade de números a ser add: ");
            int add_qntd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(add_qntd);
            
            //Dados atualizados
            System.Console.WriteLine($"\nDados atualizados: {p}\n");

            //Remover
            System.Console.Write("Digite a quantidade de números a ser retirado: ");
            int remover_qntd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(remover_qntd);
            
            //Dados atualizados
            System.Console.WriteLine($"\nDados atualizados: {p}");

            Console.WriteLine(new string('-',40));
        }
    }
}