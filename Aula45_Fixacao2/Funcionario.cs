using System;
using System.Security.Cryptography;
using System.Globalization;

namespace Course{
    class Funcionario{

        public string nome;
        public double SalarioBruto;
        public double imposto;

        public double SalarioLiquido(){
            return SalarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem){
            SalarioBruto += (SalarioBruto * porcentagem)/100;
        }

        public override string ToString()
        {
            return $"Funcionário: {nome}, R${SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}