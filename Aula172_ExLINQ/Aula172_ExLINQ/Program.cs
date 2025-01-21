using System.Numerics;
using Aula172_ExLINQ.Entities;

namespace Aula172_ExLINQ
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection){
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Electronics", 1);

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print("Tier 1 and Price < 900:", r1);
            // var r1 =
            //      from p in products 
            //      where p.Category.Tier == 1 && p.Price < 900.00
            //      select p

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names of products from tools:",r2);
            // var r2 = 
            //      from p in produts 
            //      where p.Category.Name == "Tools"
            //      select p.Name

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
            Print("Name started with 'C' and object", r3);
            // var r3 =
            //      from p in products
            //      where p.Name[0] = 'C'
            //      select new {p.Name, p.Price, CategoryName = p.Category.Name} 

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price then by name:", r4);
            // var r4 = 
            //      from p in products
            //      where p.Category.Tier == 1
            //      orderby p.Name
            //      orderby p.Price
            //      select p;
            
            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 order by price then by name skip take 4:", r5);
            // var v5 =
            //      ( from p in r4 
            //      select p )
            //      .Skip(2).Take(4)

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First test1: " + r6);

            var r7 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Sigle (Id = 3): " + r7);
            Console.WriteLine();

            var r8 = products.Max(p => p.Price);
            Console.WriteLine("Max price:" + r8);

            var r9 = products.Min(p => p.Price);
            Console.WriteLine("Min price:" + r9);

            var r10 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r10);

            var r11 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Avarage prices: " + r11);

            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category); 
            foreach (IGrouping<Category, Product> group in r16) {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group) {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
