using System;
using System.Globalization;

int senha = 0;

while (senha != 2002)
{
    Console.Write("Senha: ");
    senha = int.Parse(Console.ReadLine());
    if (senha != 2002)
    {
        Console.WriteLine("Senha Inválida!\n");
    }
}
Console.WriteLine("Acesso permitido!\n");