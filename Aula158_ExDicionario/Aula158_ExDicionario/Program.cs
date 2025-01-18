using System.IO;

namespace Aula158_ExDicionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dict = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)){

                    while (!sr.EndOfStream) {

                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (dict.ContainsKey(name)) {
                            int currentVotes = dict[name];
                            int totalVotes = dict[name] + votes;
                            dict[name] = totalVotes;
                        }
                        else{
                            dict[name] = votes;
                        }

                    }
                }

                foreach (var item in dict){
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            catch (IOException e){
                Console.WriteLine("An error occured: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
