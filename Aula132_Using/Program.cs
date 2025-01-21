namespace Aula132_Using
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"Caminho\do\file1.txt";

            try{
                using (StreamReader sr = File.OpenText(path)){
                    while (!sr.EndOfStream){
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e){
                System.Console.WriteLine("An error occurred::");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}
