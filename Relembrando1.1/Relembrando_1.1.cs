using System;
using System.Globalization;


CultureInfo CI = CultureInfo.InvariantCulture;

int cod1 = int.Parse(Console.ReadLine());
int qntd1 = int.Parse(Console.ReadLine());
float valor1 = float.Parse(Console.ReadLine());
Console.WriteLine();

int cod2 = int.Parse(Console.ReadLine());
int qntd2 = int.Parse(Console.ReadLine());
float valor2 = float.Parse(Console.ReadLine());

float valor = (qntd1 * valor1) + (qntd2 * valor2);
Console.WriteLine($"Valor total: R${valor}");
