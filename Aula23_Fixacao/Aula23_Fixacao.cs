using System;
using System.Globalization;

namespace Aula23_Fixacao{
    class Program{
        static void Main(string[] args){

            string nome;
            int quartos;
            float preco;

            Console.WriteLine(new string('-',30)+ "Perguntas" + new string('-', 30));
            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na casa? ");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] lista = Console.ReadLine().Split();
            
            string ultimo_nome = lista[0];
            int idade = int.Parse(lista[1]);
            float altura = float.Parse(lista[2],CultureInfo.InvariantCulture);

            Console.WriteLine(new string('-',30)+ "Respostas" + new string('-', 30));
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimo_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(new string('-',70));
        }
    }
}