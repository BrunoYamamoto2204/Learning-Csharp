namespace Aula134_Directory
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"Caminho\da\Pasta";

            try{
                // Mostra todos os diretórios de um diretório 
                var folders = Directory.EnumerateDirectories(path,"*.*",SearchOption.TopDirectoryOnly);
                System.Console.WriteLine("FOLDERS:");
                foreach (string s in folders) {
                    System.Console.WriteLine(s);
                }

                // Mostra todos os arquivos de um diretório
                var files = Directory.EnumerateFiles(path,"*.*",SearchOption.AllDirectories);
                System.Console.WriteLine("FILES:");
                foreach (string s in files) {
                    System.Console.WriteLine(s);
                }

                // Cria uma pasta nova
                Directory.CreateDirectory(path + "\\newFolder");
            }
            catch (IOException e){
                System.Console.WriteLine("An error occured");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}
