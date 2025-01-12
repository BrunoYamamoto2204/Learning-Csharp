using Aula105_Fixacao.Entities;
using Aula105_Fixacao.Entities.Enums;
using System;
using System.Globalization;

namespace Aula105_Fixacao
{
    class Program
    {
        public static void Main(string[] args)
        {

        System.Console.WriteLine("Enter cliente data:");
        System.Console.Write("Name: ");  
        string name = Console.ReadLine();
        System.Console.Write("Email: ");
        string email = Console.ReadLine();
        System.Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        
        System.Console.WriteLine("\nEnter order data:");
        System.Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Client client = new Client(name, email, date);
        Order order = new Order(DateTime.Now, status, client);

        System.Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            System.Console.WriteLine($"\nEnter #{i} items data:");
            System.Console.Write("Product Name: ");
            string productName = Console.ReadLine();
            System.Console.Write("Product Price: ");
            double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Product product = new Product(productName, price);

            System.Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(quantity, price, product);
            order.AddItem(orderItem);
        }

        System.Console.WriteLine("\nORDER SUMMANRY:");
        System.Console.WriteLine(order);
        
        foreach (OrderItem obj in order.Orders)
        {
            System.Console.WriteLine(obj);
        }

        System.Console.WriteLine($"Total price: ${order.Total()}");
        
        }
    }
}