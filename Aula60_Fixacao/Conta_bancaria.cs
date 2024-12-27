using System;
using System.Globalization;

namespace Course{
    class Conta_bancaria{

        private string Nome {get; set;}
        public int Num_conta {get; private set;}
        public double Saldo { get; private set;}
        
        public Conta_bancaria (string nome, int num_conta){
            Nome = nome;
            Num_conta = num_conta;
            Saldo = 0;
        }
        public Conta_bancaria (string nome, int num_conta, double saldo_inicial) : this(nome,num_conta) {
            Deposito(saldo_inicial);
        }
        
        public void Deposito (double valor){
            Saldo += valor;
        }
        public void Saque (double valor){
            Saldo -= valor + 5;
        }
        public override string ToString() {
            return $"Conta {Num_conta}, Titular: {Nome}, Saldo: R$ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
} 