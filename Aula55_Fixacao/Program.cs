using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Produto p = new Produto("TV", 500.00, 10);
            
            p.SetNome("TV 4K");

            System.Console.WriteLine(p.GetNome());

            Console.WriteLine(new string('-',40));
        }
    }
}