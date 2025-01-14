using Aula128_Fixacao.Entities.Exceptions;

namespace Aula128_Fixacao.Entities
{
    class Account
    {   
        // Atributos
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        // Construtores
        public Account (){}
        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // Métodos 
        public void withdraw (double amount)
        {
            if (amount > WithdrawLimit){
                throw new DomainException("Amount cannot be greater than withdraw limit!");
            }
            if (amount > Balance){
                throw new DomainException("Insufficient balance!");
            }
            
            Balance -= amount;
        }
        public void Deposit (double amount)
        {
            Balance += amount;
        }
    }
}