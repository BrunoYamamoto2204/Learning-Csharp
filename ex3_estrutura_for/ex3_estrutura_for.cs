using System;

namespace ex3_estrutura_for{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            System.Console.Write("Fatorial de: ");
            int num = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int fat = num; fat > 0; fat --){
                fatorial *= fat;
            }

            System.Console.WriteLine($"Resultado: {fatorial}");
            Console.WriteLine(new string('-',40));
        }
    }
}