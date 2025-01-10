using System;

namespace Course{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            string[] dimensao = Console.ReadLine().Split(' ');
            int linhas = int.Parse(dimensao[0]);
            int colunas = int.Parse(dimensao[1]);
            int[,] matriz = new int[linhas,colunas];

            for (int linha = 0; linha < linhas; linha++){
                string[] values = Console.ReadLine().Split(" ");
                for (int coluna = 0; coluna < colunas; coluna++){
                    matriz[linha,coluna] = int.Parse(values[coluna]);
                }
            }

            int esc_num = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < linhas; linha++){
                for (int coluna = 0; coluna < colunas; coluna++){
                    if (matriz[linha,coluna] == esc_num){
                        System.Console.WriteLine($"Position {linha},{coluna}:");

                        if (coluna > 0){
                            System.Console.WriteLine($"Left: {matriz[linha, coluna-1]}");
                        }
                        if (coluna < colunas-1){     
                            System.Console.WriteLine($"Right: {matriz[linha, coluna+1]}");
                        }
                        if (linha < linhas - 1){
                            System.Console.WriteLine($"Down: {matriz[linha + 1, coluna]}");
                        }
                        if (linha > 0){
                            System.Console.WriteLine($"Up: {matriz[linha - 1, coluna]}");
                        }
                    }
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();
            Console.WriteLine(new string('-',40));
        } 
    }
}