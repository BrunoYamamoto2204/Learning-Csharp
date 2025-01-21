using Aula168_Action.Entities;

namespace Aula168_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = UpdatePrice;
            // Action<Product> act = { p.Price += p.Price * 0.1; };

            list.ForEach(act);
            foreach ( Product p in list) {
                Console.WriteLine(p);
            }
        }       

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
