using Aula156_ExConjuntos.Entities;

namespace Aula156_ExConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> set = new HashSet<Students>();    

            Console.Write("How many students for course A? ");
            int numA = int.Parse(Console.ReadLine());

            for (int a = 0; a < numA; a++){
                int registrationNumber = int.Parse(Console.ReadLine()); 
                set.Add(new Students{Number = registrationNumber});
            }

            Console.Write("How many students for course B? ");
            int numB = int.Parse(Console.ReadLine());
            for (int b = 0; b < numB; b++)
            {
                int registrationNumber = int.Parse(Console.ReadLine());
                set.Add(new Students { Number = registrationNumber });
            }

            Console.Write("How many students for course C? ");
            int numC = int.Parse(Console.ReadLine());
            for (int c = 0; c < numC; c++)
            {
                int registrationNumber = int.Parse(Console.ReadLine());
                set.Add(new Students { Number = registrationNumber });
            }

            Console.WriteLine($"Total students: {set.Count()}");

        }
    }
}