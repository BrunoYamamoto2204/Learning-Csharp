using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Aluno a = new Aluno();

            System.Console.Write("Nome do aluno: ");
            a.nome = Console.ReadLine();

            System.Console.WriteLine("Digite as três notas do aluno:");
            a.n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.n3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double media = a.Media();

            System.Console.WriteLine("Nota final: "+media.ToString("F1",CultureInfo.InvariantCulture));

            if (a.Aprovacao()){
                System.Console.WriteLine("APROVADO!");
            } else{
                System.Console.WriteLine("REPROVADO!");
                System.Console.WriteLine($"Faltaram {a.Faltam().ToString("F1",CultureInfo.InvariantCulture)} Pontos");
            }
        
            Console.WriteLine(new string('-',40));
        }
    }
}