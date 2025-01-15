using System.Globalization;
using Aula136_ExFixacao.Entities;

namespace Aula136_ExFixacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter Path: ");
            string path = Console.ReadLine();

            try {
                string[] lines = File.ReadAllLines(path);

                string sourceFolderPath = Path.GetDirectoryName(path);
                string targetFolderPath = sourceFolderPath + @"\tagetFolder";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath)) {
                    foreach (string line in lines) {

                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1],CultureInfo.InstalledUICulture);
                        int quantity = int.Parse(fields[2]);

                        Product p = new Product(name,price,quantity);
                        sw.WriteLine ($"{p.Name}, {p.TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (Exception e) {
                System.Console.WriteLine("An error acurred");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}