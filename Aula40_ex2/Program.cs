using System;
using Course;
using System.Globalization;

namespace Teste{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            System.Console.WriteLine("Dados do primeiro funcionário:");
            System.Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            System.Console.Write("Salário: R$");
            f1.salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            System.Console.WriteLine("Dados do segundo funcionário:");
            System.Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            System.Console.Write("Salário: R$");
            f2.salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            float media = (f2.salario + f1.salario)/2;
            System.Console.WriteLine("Salário médio = R$"+media.ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine(new string('-',40));
        }
    }
}