using System;

namespace ex2_estrutura_for{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            System.Console.Write("Número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',40));
            
            System.Console.WriteLine($"Divisores de {num}:");
            for (int div = 1; div <= num; div++){
                int check = num/div;
                if (num%div == 0){
                    System.Console.WriteLine(div);
                }
            }

            Console.WriteLine(new string('-',40));
        }
    }
}