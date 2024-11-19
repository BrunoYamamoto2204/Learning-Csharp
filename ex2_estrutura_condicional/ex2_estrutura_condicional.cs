using System;
using System.Globalization;

namespace ex2_estrutura_condicional{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            System.Console.Write("Escreva um número no intervalo de 0 - 100: ");
            float num = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (num >= 0 && num <=25){
                System.Console.WriteLine("Intervalo (0,25)");
            }
            else if (num >= 25 && num <=50){
                System.Console.WriteLine("Intervalo (25,50)");
            }
            else if (num >= 50 && num <=75){
                System.Console.WriteLine("Intervalo (50,75)");
            }
            else if (num >= 75 && num <=100){
                System.Console.WriteLine("Intervalo (75,100)");
            }
            else{
                System.Console.WriteLine("Fora do intervalo");
            }

            Console.WriteLine(new string('-',40));
        }
    }
}