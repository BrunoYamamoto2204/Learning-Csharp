namespace Aula157_Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["users"] = "maria";
            cookies["emial"] = "maria@gmail.com";
            cookies["phone"] = "99712234";

            Console.WriteLine("Size: " + cookies.Count());

            Console.WriteLine("All cookies: ");
            foreach(var item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
