using System.Globalization;

namespace Course{
    class Funcionario{

        public int Id {get; set;}
        public string Nome {get; set;}
        public double Salary {get; set;}

        public Funcionario (int id, string nome, double salary){
            Id = id;
            Nome = nome;
            Salary = salary;
        }

        public void AumentoSalario(double porcentagem){
            Salary += Salary * porcentagem/100;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}