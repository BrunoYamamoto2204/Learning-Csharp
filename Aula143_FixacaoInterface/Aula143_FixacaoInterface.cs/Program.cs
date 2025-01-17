using System;
using System.Globalization;
using Aula143_FixacaoInterface.cs.Entities;
using Aula143_FixacaoInterface.cs.Services;

namespace Aula143_FixacaoInterface
{
    class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(num, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(contract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
