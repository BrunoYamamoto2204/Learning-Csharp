using System;
using System.Globalization;
using Aula115_Fixacao.Entities;

namespace Aula115_Fixacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(new String('-', 40));

            List<Product> Products = new List<Product>();

            System.Console.Write("Enter the Number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int p = 1; p <= n; p++)
            {
                System.Console.WriteLine($"\nProduct #{p} data:");
                System.Console.Write("Common, user or imported (c/u/i): ");
                string cui = Console.ReadLine().ToLower();
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (cui == "c")
                {
                    Product product = new Product(name, price);
                    Products.Add(product);
                }
                else if (cui == "u")
                {
                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Product product = new UsedProduct(name, price, date);
                    Products.Add(product);
                }
                else if (cui == "i")
                {
                    System.Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product = new ImportedProduct(name, price, fee);
                    Products.Add(product);
                }
            }

            System.Console.WriteLine("\nPRICE TAGS:");
            foreach (Product p in Products)
            {
                System.Console.WriteLine(p.PriceTag());
            }

            System.Console.WriteLine(new String('-', 40));
        }
    }
}