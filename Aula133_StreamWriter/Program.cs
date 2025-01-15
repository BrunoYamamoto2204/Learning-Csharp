namespace Aula133_StreamWriter
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"Caminho\do\file1.txt";
            string targetPath = @"Caminho\do\file2.txt";

            try{
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)){
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    
                    }
                }
            }
            catch (IOException e){
                
            }

        }
    }
}

