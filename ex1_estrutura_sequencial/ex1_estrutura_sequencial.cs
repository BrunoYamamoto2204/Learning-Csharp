using System;

namespace ex1_estrutura_sequencial{
    class Program{
        static void Main(string[] args){

            Console.WriteLine(new string('-',30));
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1+n2;
            
            System.Console.WriteLine($"Soma = {soma}");
            Console.WriteLine(new string('-',30));
            
        }
    }
}
