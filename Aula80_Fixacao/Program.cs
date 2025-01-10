using System;
using Microsoft.VisualBasic;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            int N = int.Parse(Console.ReadLine());
            
            int[,] matriz = new int[N,N];
            int negativos = 0;

            for (int linha = 0; linha < N; linha++){

                string[] values = Console.ReadLine().Split(" ");

                for (int coluna = 0; coluna < N; coluna++){
                    matriz[linha,coluna] = int.Parse(values[coluna]);
                    
                    if (matriz[linha,coluna] < 0){
                        negativos += 1;
                    }
                }
            }

            System.Console.WriteLine("Main diagonal:");
            for (int e = 0; e < N; e++){
                System.Console.Write(matriz[e,e] + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Números nagetivos: {negativos}");
             
            Console.WriteLine(new string('-',40));
        } 
    }
}
