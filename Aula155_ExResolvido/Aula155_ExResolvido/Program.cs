using System;
using Aula155_ExResolvido.Entities;

namespace Aula155_ExResolvido
{
    class Program {
        static void Main(string[] args) { 

            HashSet<LogRegister> logs = new HashSet<LogRegister>();
            int users = 0;

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try{
                using (StreamReader sr = File.OpenText(path)){
                    while (!sr.EndOfStream){
                        string[] line = sr.ReadLine().Split(" ");

                        string name = line[0];
                        DateTime IsoDate = DateTime.Parse(line[1]);
                        logs.Add(new LogRegister(name, IsoDate));

                    }

                    Console.Write("Total users: ");
                    Console.WriteLine(logs.Count());
                }
            }

            catch (IOException e){
                Console.WriteLine("An Error Occured:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
