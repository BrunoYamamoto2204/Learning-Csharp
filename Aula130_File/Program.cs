using System.IO;

namespace Aula130_File
{
    class Program
    {
        public static void Main(string[] args)
        {

            string sourcePath = @"Caminho\do\file1.txt";
            string targetPath = @"Caminho\do\file2.txt";

            try{
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines){
                    System.Console.WriteLine(line);
                }

            }
            catch (IOException e){
                System.Console.WriteLine("An error occured:");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}