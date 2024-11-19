using System;
using System.Globalization;

namespace ex5_estrutura_sequencial{
    class Program{
        static void Main(string[] args){

            Console.WriteLine(new string('-',10)+ "Peça 1" + new string('-', 10));
            string[] peca1 = Console.ReadLine().Split();
            int cod1 = int.Parse(peca1[0]);
            int qntd1 = int.Parse(peca1[1]);
            float valor1 = float.Parse(peca1[2],CultureInfo.InvariantCulture);
            float total1 = valor1*qntd1;

            Console.WriteLine(new string('-',10)+ "Peça 2" + new string('-', 10));
            string[] peca2 = Console.ReadLine().Split();
            int cod2 = int.Parse(peca2[0]);
            int qntd2 = int.Parse(peca2[1]);
            float valor2 = float.Parse(peca2[2],CultureInfo.InvariantCulture);
            float total2 = valor2*qntd2;

            float total = total1 + total2;
            System.Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine(new string('-',40));
        }
    }
}