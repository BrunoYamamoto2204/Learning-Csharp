using System;

namespace ex3_estrutura_sequencial{
    class Program{
        static void Main(string[] args){
            
            Console.WriteLine(new string('-',40));
            System.Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
            System.Console.Write("C = ");
            int c = int.Parse(Console.ReadLine());
            System.Console.Write("D = ");
            int d = int.Parse(Console.ReadLine());

            int resultado = (a*b) - (c*d);
            System.Console.WriteLine($"Diferença: {resultado}");
            Console.WriteLine(new string('-',40));
        }
    }
}