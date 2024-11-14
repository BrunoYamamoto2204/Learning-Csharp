using System;

namespace Teste{
    class Program{
        static void Main(string[] args){

            string s = Console.ReadLine();
            string[] var = s.Split("a");

            Console.WriteLine(var[0]);
            Console.WriteLine(var[1]);
        }
    }
}