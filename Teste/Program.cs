using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            int[] array = new int[] {1,2,3};
            List<int> lista = new List<int> {4,5,6};

            int achou = lista.Find(x => x == 5);
            System.Console.WriteLine(achou);
        
            // foreach(int c in lista){
            //     Console.Write(c + " ");
            // }


            System.Console.WriteLine();
            Console.WriteLine(new string('-',40));
        } 
    }
}