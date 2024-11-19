using System;
using System.Globalization;

namespace ex1_estrutura_condicional{
    class Program{
        static void Main(string[] args){
            Console.WriteLine(new string('-',40));

            System.Console.Write("Renda: R$");
            float renda = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float valor_imposto = 0;

            // Renda Menor que R$2000 - Isento
            // Renda entre R$2000.1 e R$3000.00 - 8% do valor entre essa margem
            // Renda entre R$3001.1 e R$4500.00 - 18% do valor entre essa margem
            // Maior que R$4500.00 - 28% de todo valor que utrapassar 

            //ex: Renda = R$4502
            //Imposto:
            // - 0% no R$2000 (entre 0 e 2000)
            // - 8% no R$1000 (entre 2000 e 3000)
            // - 18% no R$1500 (entre 3000 e 4500)
            // - 28% no R$2 (acima de 4500)
            // R$2000 + R$1000 + R$1500 + R$2 = R$4502

            if (renda > 0 && renda <= 2000){
                System.Console.WriteLine("ISENTO");
            }
            else if (renda > 2000 && renda <= 3000){
                valor_imposto = (renda - 2000) * 0.08f;
                System.Console.WriteLine(valor_imposto.ToString("F2",CultureInfo.InvariantCulture));
            }
            else if (renda > 3000 && renda <= 4500){
                valor_imposto = 1000 * 0.08f + (renda - 3000) * 0.18f;
                System.Console.WriteLine(valor_imposto.ToString("F2",CultureInfo.InvariantCulture));
            }
            else if (renda > 4500){
                valor_imposto = 1000 * 0.08f + 1500 * 0.18f + (renda-4500) * 0.28f;
                System.Console.WriteLine(valor_imposto.ToString("F2",CultureInfo.InvariantCulture));
            }

            Console.WriteLine(new string('-',40));
        }
    }
}