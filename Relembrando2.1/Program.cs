using System;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

List<float> valores = new List<float> {0f,4.0f,4.5f,5f,2f,1.5f};

Console.WriteLine("1 - Cachorro Quente - R$4.0\n2 - X-Salada - R$4.50\n3 - X-Bacon - R$5.00\n4 - Torrada simples - R$2.00\n5 - Refrigerante - R$1.50");

Console.Write("\nCódigo do produto: ");
int cod = int.Parse(Console.ReadLine());

Console.Write("Quantidade: ");
int qntd = int.Parse(Console.ReadLine());

float valor = valores[cod];
float total = valor*qntd;

Console.WriteLine($"Valor total: R${total.ToString("F2",CI)}");


