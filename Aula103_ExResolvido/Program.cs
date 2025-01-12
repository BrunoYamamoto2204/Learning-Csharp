using System;
using Aula103_ExResolvido.Entities;

namespace Aula103_ExResolvido
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new string('-',40));

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post (
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm gonna visit this beautiful country!",
                12
            );
            p1.AddComent(c1);
            p1.AddComent(c2);

            System.Console.WriteLine(p1);

            Console.WriteLine(new string('-',40));
        }
    }
}



