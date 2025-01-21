using System.Globalization;

namespace Aula177_ExFixacao.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter Salary: ");
            double desiredSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IEnumerable<string> emails = employees.Where(e => e.Salary > desiredSalary).OrderBy(e => e.Email).Select(e => e.Email).ToList();



            Console.WriteLine($"\nEmail of people whose salary is more than {desiredSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            foreach (string e in emails){
                Console.WriteLine(e);
            }

            double sumSalaryM = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.Write("\nSum of salary of people whose name starts with 'M': " + sumSalaryM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
