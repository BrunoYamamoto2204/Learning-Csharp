
using System.Globalization;

namespace Aula143_FixacaoInterface.cs.Entities
{
    class Installment
    {   
        // Atributos
        public DateTime DueDate{ get; set; }
        public double Amout{ get; set; }

        // Construtor
        public Installment(DateTime dueDate, double amout) { 
            DueDate = dueDate;
            Amout = amout;
        }

        // Métodos
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amout.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
