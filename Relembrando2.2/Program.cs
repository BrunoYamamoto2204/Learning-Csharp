using System;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

Console.Write("X2: ");
float a = float.Parse(Console.ReadLine());
Console.Write("X: ");
float b = float.Parse(Console.ReadLine());
Console.Write("Num: ");
float c = float.Parse(Console.ReadLine());

float delta = (float)(Math.Pow(b,2)-4*a*c);
if (a != 0 && delta > 0){
    float x1 = (float) ((-b + Math.Sqrt(delta)) / (2*a));
    float x2 = (float) ((-b - Math.Sqrt(delta)) / (2*a));

    Console.WriteLine($"X1 = {x1.ToString("F4",CI)}");
    Console.WriteLine($"X2 = {x2.ToString("F4",CI)}");
}
else{
    Console.WriteLine("IMpossível calcular!");
}
