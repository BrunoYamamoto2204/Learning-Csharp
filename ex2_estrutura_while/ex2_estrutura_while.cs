using System;

namespace ex2_estrutura_while{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));
            Console.WriteLine("Digite os valores de X e Y para determinar o quadrante.");
            Console.WriteLine("Para encerrar, insira 0 para X ou Y.");
            Console.WriteLine(new string('-', 40));

            while (true){
                System.Console.Write("Digite o X e Y(na mesma linha): ");
                string[] quadrantes = Console.ReadLine().Split();
                int primeiro_q = int.Parse(quadrantes[0]);
                int segundo_q = int.Parse(quadrantes[1]);

                if (primeiro_q > 0 && segundo_q > 0){
                    System.Console.WriteLine("1a Quadrante");
                }
                else if (primeiro_q < 0 && segundo_q > 0){
                    System.Console.WriteLine("2a Quadrante");
                }
                else if (primeiro_q < 0 && segundo_q < 0){
                    System.Console.WriteLine("3a Quadrante");
                }
                else if (primeiro_q > 0 && segundo_q < 0){
                    System.Console.WriteLine("4a Quadrante");
                }
                else if (primeiro_q == 0 || segundo_q == 0){
                    break;
                }
                else{
                    System.Console.WriteLine("Origem");
                }
            }

            Console.WriteLine(new string('-',40));
        //final
        }
    }
}
