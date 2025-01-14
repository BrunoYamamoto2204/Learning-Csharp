using System.Globalization;

namespace Aula115_Fixacao.Entities
{
    class ImportedProduct : Product
    {   
        // Atributos
        public double CustomsFee { get; set; }

        // Construtores
        public ImportedProduct(){}
        public ImportedProduct(string name, double price, double customsFee )
            : base (name,price)
        {
            CustomsFee = customsFee;
        }

        // Métodos
        public double TotalPrice ()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}