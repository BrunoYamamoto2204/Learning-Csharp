using Aula176_ExResolvindoLINQ.Enitites;
using System.Globalization;

namespace Aula176_ExResolvindoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream){
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        double price = double.Parse(line[1],CultureInfo.InvariantCulture);

                        products.Add(new Product(name, price));
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error with the database: ");
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("An error occurred: ");
            }

            double avarage = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            IEnumerable<string> belowAvarage= products.Where(p => p.Price < avarage).OrderByDescending(p => p.Name).Select(p => p.Name);

            Console.WriteLine("Avarage price: " + avarage.ToString("F2",CultureInfo.InvariantCulture));

            foreach (string p in belowAvarage) {
                Console.WriteLine(p);
            }
        }
    }
}
