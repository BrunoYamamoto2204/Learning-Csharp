using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            Students[] salas = new Students[10];

            System.Console.Write("How Many rooms will be rented? ");
            int num_quartos = int.Parse(Console.ReadLine());

            for (int c = 0; c < num_quartos; c++){
                
                System.Console.WriteLine($"\nRent #{c+1}:");

                System.Console.Write("Name: ");
                string nome = Console.ReadLine();

                System.Console.Write("Email: ");
                string email = Console.ReadLine();

                System.Console.Write("Room: ");
                int numero = int.Parse(Console.ReadLine());

                salas[numero] = new Students(nome,email);

            }

            System.Console.WriteLine("\nBusy rooms:");
            for (int c = 0; c < 10; c++){
                if (salas[c] != null){
                    System.Console.WriteLine($"{c}: {salas[c]}");
                }
            }

            Console.WriteLine(new string('-',40));

        }
    }
}