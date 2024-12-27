using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Produto p = new Produto("TV", 500.00, 10);
            
            p.Nome = "TV 4K";

            System.Console.WriteLine(p.Nome);
            System.Console.WriteLine(p.Preco);

            Console.WriteLine(new string('-',40));
        }
    }
}