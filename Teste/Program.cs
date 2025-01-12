using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-',40));

            string[] data = Console.ReadLine().Split("/");
            int mes = int.Parse(data[0]);
            int ano = int.Parse(data[1]);

            System.Console.WriteLine($"Mês: {mes}");
            System.Console.WriteLine($"Ano: {ano}");
        
            Console.WriteLine(new string('-',40));

            
        } 
    }
}