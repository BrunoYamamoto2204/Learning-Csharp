

namespace Aula143_FixacaoInterface.cs.Entities
{
    class Contract
    {   
        
        // Atributos 
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } 

        // Construtor 
        public Contract (int number, DateTime date, double totalValue) { 
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        //Métodos
        public void addInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
