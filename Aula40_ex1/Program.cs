using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            System.Console.WriteLine("Dados da primeira pessoa:");
            System.Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segunda pessoa:");
            System.Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade){
                System.Console.WriteLine("Pessoa mais velha:"+p1.nome);
            }
            else{
                System.Console.WriteLine("Pessoa mais velha:"+p2.nome);
            }

            Console.WriteLine(new string('-',40));
        }
    }
}