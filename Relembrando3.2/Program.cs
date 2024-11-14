using System;
using System.Globalization;

int dentro=0,fora=0,c,qntd;

Console.Write("Número de repetições: ");
qntd = int.Parse(Console.ReadLine());

for (c = 0; c < qntd; c++){
    Console.Write($"Número {c}: ");
    int num = int.Parse(Console.ReadLine());

    if (num >= 10 && num <= 20){
        dentro += 1;
    }
    else{
        fora += 1;
    }
}
Console.WriteLine(dentro + " in");
Console.WriteLine(fora + " out");