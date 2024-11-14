using System;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

Console.Write("Raio do círculo: ");
float raio = float.Parse(Console.ReadLine());

float area = (float)(3.14 *Math.Pow(raio,2));
Console.WriteLine($"Área do círculo: {area.ToString("F2",CI) }");