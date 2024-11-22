using System;


//*exercício 07
namespace Teste{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));
            System.Console.WriteLine("1a Coluna - Número");
            System.Console.WriteLine("2a Coluna - Quadrado do número");
            System.Console.WriteLine("3a Coluna - Cubo do número");
            Console.WriteLine(new string('-',40));
            
            System.Console.Write("Número: ");
            int num = int.Parse(Console.ReadLine());

            for (int c = 1; c <= num; c++){
                System.Console.WriteLine($"{c} {Math.Pow(c,2)} {Math.Pow(c,3)}");
            }

            Console.WriteLine(new string('-',40));
        }
    }
}