using System;

namespace ex1_estrutura_while{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            System.Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002){
                System.Console.Write("Senha incorreta! Digite novemente: ");
                senha = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Acesso permitido!");
            Console.WriteLine(new string('-',40));
        }
    }
}