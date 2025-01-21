using System;
using Aula165_Delegates.Services;
namespace Aula165_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            // double result = op(a, b); 
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}