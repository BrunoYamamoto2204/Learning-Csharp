namespace Aula131_FileStream
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"Caminho\do\file1.txt";

            StreamReader sr = null;
            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream){
                    string line = sr.ReadLine();
                    System.Console.WriteLine(line);
                }
            }
            catch (IOException e){
                System.Console.WriteLine("An error accurred:");
                System.Console.WriteLine(e.Message);
            }
            finally{
                if (sr != null) {
                    sr.Close();
                }
            }
        }
    }
}