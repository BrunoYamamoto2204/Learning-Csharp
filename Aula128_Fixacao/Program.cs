using Aula128_Fixacao.Entities.Exceptions;
using Aula128_Fixacao.Entities;
using System.Globalization;

namespace Aula128_Fixacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter accout data:");
                System.Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.Write("Holder: ");
                string holder = Console.ReadLine();
                System.Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                System.Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Account account = new Account(number,holder,balance,withdrawLimit);

                System.Console.Write("\nEnter amount for withdraw: ");
                account.withdraw(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

                System.Console.WriteLine("New Balance: " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }

            catch (DomainException e)
            {
                System.Console.WriteLine("Withdraw error: " + e.Message);
            }

            catch (Exception e)
            {
                System.Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}