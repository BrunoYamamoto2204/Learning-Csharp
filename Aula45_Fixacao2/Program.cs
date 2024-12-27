using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Funcionario f = new Funcionario();

            System.Console.Write("Nome: ");
            f.nome = Console.ReadLine();

            System.Console.Write("Salário bruto: R$");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            System.Console.Write("Imposto(%): ");
            f.imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            
            System.Console.WriteLine();
            System.Console.WriteLine(f);

            System.Console.WriteLine();
            System.Console.Write("Digite a porcentagem para aumentar o salário(%): ");
            double aumento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f.AumentarSalario(aumento);

            System.Console.WriteLine();
            System.Console.WriteLine(f);

            Console.WriteLine(new string('-',40));
        }
    }
}