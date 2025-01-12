using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            string original = "abcde FGHIJ KLM nop QRST     ";
            string upper = original.ToUpper(); //Tudo Minúsculo 
            string lower = original.ToLower(); // Tudo Maiúsculo 
            string trim = original.Trim(); // Retira os espaços vazios no começo e final da string 
            int index_of = original.IndexOf("bc"); // Acha a posição de uma string dentro da string maior 
            string substring = original.Substring(3,5); // Faz um fatimento da string original => (começa, quantidade de caracteres depois)
            string replace = original.Replace("abcde","wxyz"); // Subtitui uma parte da string por outra 
            string[] split = original.Split(' ');

            System.Console.WriteLine($"-{original}-");
            // foreach(string c in split){
            //     System.Console.WriteLine(c);
            // }

            Console.WriteLine(new string('-',40));
        } 
    }
}
