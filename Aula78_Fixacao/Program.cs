using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args){

            System.Console.Write("Quantos funcoinários serão registrados? ");
            int n_funcionarios = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int e = 0; e < n_funcionarios; e++){
                System.Console.WriteLine($"Funcionário #{e+1}:");

                System.Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
                System.Console.WriteLine();

            }
            
            System.Console.Write("Insira o ID do funcionário que vai ter aumento de salário: ");
            int id_aumento = int.Parse(Console.ReadLine());

            Funcionario id_func = funcionarios.Find(obj => obj.Id == id_aumento);

            if (id_func != null){
                System.Console.Write("Insira a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                id_func.AumentoSalario(porcentagem);
            }
            else{
                System.Console.WriteLine("Este ID não existe");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Lista de usuários atualizadas:");
            foreach(Funcionario obj in funcionarios){
                System.Console.WriteLine(obj);
            }
            
        }

    }
}