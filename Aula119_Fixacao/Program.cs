using System;
using System.Globalization;
using Aula119_Fixacao.Entities;

namespace Aula119_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(new string('-',40));

            List<TaxPayer> list = new List<TaxPayer>();

            System.Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int p = 1; p <= n; p++)
            {
                System.Console.WriteLine($"\nTax payer #{p} data:");
                System.Console.Write("Individual or company (i/c):");
                string ic = Console.ReadLine().ToLower();
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                if (ic == "i"){
                    System.Console.Write("Health expenditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome,healthExpeditures));
                }
                else{
                    System.Console.Write("Number of employees: ");
                    int employees =int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, employees));
                }
            }

            double totalTax = 0;
            System.Console.WriteLine("\nTAXES PAID:");
            foreach (TaxPayer p in list)
            {   
                totalTax += p.TaxPayed();
                System.Console.WriteLine($"{p.Name}: $ {p.TaxPayed().ToString("F2",CultureInfo.InvariantCulture)}");
            }

            System.Console.WriteLine($"\nTOTAL TAXES: $ {totalTax.ToString("F2",CultureInfo.InvariantCulture)}");
            
            System.Console.WriteLine(new string('-',40));
        }
    }
}
