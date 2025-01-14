using System.Globalization;
using Aula113_ExResolvido.Entities;

namespace Aula113_ExResolvido
{
    class Program 
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine(new string('-',40));

            List<Employee> Employees = new List<Employee>();

            System.Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int e = 1; e <= n; e++)
            {
                System.Console.WriteLine($"\nEmployee #{e} data:");
                System.Console.Write("Outsourced (y/n): ");
                string outsourced = Console.ReadLine();
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine()); 
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 

                if (outsourced == "y"){
                    System.Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 

                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, addCharge);
                    Employees.Add(employee);
                }
                else{
                    Employee employee = new Employee(name, hours, valuePerHour);
                    Employees.Add(employee);
                }

            }

            System.Console.WriteLine("\nPAYMENTS:");
            foreach (Employee e in Employees){
                System.Console.WriteLine($"{e.Name} - ${e.Payment().ToString("F2",CultureInfo.InvariantCulture)}");
            }

            System.Console.WriteLine(new string('-',40));
        }
    }
}