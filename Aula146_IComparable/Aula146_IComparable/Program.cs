using System;
using System.IO;
using Aula146_IComparable.Entities;

namespace Aula146_IComparable
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "Caminho\\do\\Arquivo\\Formato csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();

                    foreach(Employee emp in list) {
                        Console.WriteLine(emp); 
                    }
                }
            }
            catch (IOException e){
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
