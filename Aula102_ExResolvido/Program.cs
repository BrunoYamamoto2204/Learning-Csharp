﻿using System;
using System.Globalization;
using Aula102_ExResolvido.Entities;
using Aula102_ExResolvido.Entities.Enums;

namespace Aula102_ExResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-',40));

            System.Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            System.Console.WriteLine("Enter worker data:");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            System.Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            System.Console.Write("How mant contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"\nEnter #{i} contract data:");
                System.Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            System.Console.Write("\nEnter month an year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            System.Console.WriteLine($"Name: {worker.Name}");
            System.Console.WriteLine($"Deparment : {worker.Department.Name}");
            System.Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine(new string('-',40));

        }
    }
}