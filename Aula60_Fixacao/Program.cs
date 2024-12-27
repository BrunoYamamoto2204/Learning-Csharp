using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Conta_bancaria conta;

            System.Console.Write("Entre o número da conta: ");
            int num_conta = int.Parse(Console.ReadLine());
            System.Console.Write("Entre o nome do titular da conta: ");
            string nome = Console.ReadLine();
            System.Console.Write("Haverá deposito inicial(S/N)? ");
            char dep_inicial = char.Parse(Console.ReadLine());

            if (dep_inicial == 's' || dep_inicial == 'S'){
                System.Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new Conta_bancaria(nome, num_conta, saldo);
            }
            else{
                conta = new Conta_bancaria(nome, num_conta);
            }

            System.Console.WriteLine("\nDados da conta:");
            System.Console.WriteLine(conta);

            // Deposito
            System.Console.Write("\nEntre um valor para depósito:");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);

            // Saque 
            System.Console.Write("\nEntre um valor para saque:");
            double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Saque(saque);
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);

            Console.WriteLine(new string('-',40));
        }
    }
}
