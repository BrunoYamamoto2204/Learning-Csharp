using System.Reflection.Metadata.Ecma335;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string String = "Sua mãe é legal";
            string Substring = "é legal";
            
            string result = Subtract(String, Substring);
            Console.WriteLine(result);
            
        }

        static string Subtract(string String, string Substring)
        {
            string[] StringSplit = String.Split(' ');
            string[] SubstringSplit = Substring.Split(' ');

            string[] resultString = StringSplit.Where(w => !SubstringSplit.Contains(w)).ToArray();

            return string.Join(" ", resultString);
        }
    }
}
