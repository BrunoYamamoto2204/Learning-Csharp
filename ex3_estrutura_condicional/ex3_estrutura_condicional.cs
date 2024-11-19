using System;
using System.Globalization;

namespace ex3_estrutura_condicional{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            System.Console.WriteLine("1 - Cachorro Quente - R$4.00");
            System.Console.WriteLine("2 - X-Salada - R$4.50");
            System.Console.WriteLine("3 - X-Bacon - R$5.00");
            System.Console.WriteLine("4 - Torrada simples - R$2.00");
            System.Console.WriteLine("5 - Refrigerante - R$1.50");

            System.Console.Write("Código e quantidade (na mesma linnha): ");
            string[] respostas = Console.ReadLine().Split();

            int cod = int.Parse(respostas[0]);
            int qntd = int.Parse(respostas[1]);
            float preco = 0f;

            if (cod == 1){
                preco = 4.00f;
            }
            else if (cod == 2){
                preco = 4.50f;
            }
            else if (cod == 3){
                preco = 5.00f;
            }
            else if (cod == 4){
                preco = 2.00f;
            }
            else if (cod == 5){
                preco = 1.50f;
            }
            else{
                System.Console.WriteLine("Código inválido!");
                preco = 0f;
            }

            float valor = preco*qntd;
            System.Console.WriteLine($"Total: R$ {valor.ToString(("F2"),CultureInfo.InvariantCulture)}");

            Console.WriteLine(new string('-',40));
        }
    }
}
