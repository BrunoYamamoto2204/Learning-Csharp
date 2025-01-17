using System.Globalization;

namespace Aula139_Interface.Entities
{
    class Invoice
    {   
        // Atributos
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        // Contrutor
        public Invoice(double basicPayment, double tax) { 
            BasicPayment = basicPayment;    
            Tax = tax;
        }

        // Métodos  
        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"\nTotal payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
