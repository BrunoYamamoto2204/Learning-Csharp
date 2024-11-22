using System;

namespace Teste{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));
            System.Console.WriteLine("1 - Álcool");
            System.Console.WriteLine("2 - Gasolina");
            System.Console.WriteLine("3 - Diesel");
            System.Console.WriteLine("4 - Fim");
            Console.WriteLine(new string('-',40));
            
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while(true){
                System.Console.Write("Escolha de combustível: ");
                int esc = int.Parse(Console.ReadLine());

                if (esc == 1){
                    alcool += 1;
                }
                else if (esc == 2){
                    gasolina += 1;
                }
                else if (esc == 3){
                    diesel += 1;
                }
                else if (esc == 4){
                    break;
                }
                else{
                    System.Console.WriteLine("Fora do intervalo!");
                }
            }

            Console.WriteLine(new string('-',40));
            System.Console.WriteLine($"Álcool: {alcool}");
            System.Console.WriteLine($"Gasolina: {gasolina}");
            System.Console.WriteLine($"Diesel: {diesel}");
            Console.WriteLine(new string('-',40));
        }
    }
}