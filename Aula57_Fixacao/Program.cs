using System;
using System.Runtime.ConstrainedExecution;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Produto p = new Produto("TV", 500.00, 10);
            
            p.Nome = "TV 4K";
            p.RemoverProdutos(5);
            p.AdicionarProdutos(8);

            System.Console.WriteLine(p.Nome);
            System.Console.WriteLine(p.Preco);
            System.Console.WriteLine(p.Quantidade);

            Console.WriteLine(new string('-',40));
        }
    }
}