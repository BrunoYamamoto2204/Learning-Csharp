namespace Aula119_Fixacao.Entities
{
    abstract class TaxPayer
    {
        // Atributos 
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        // Construtores
        public TaxPayer (string name, double anualIncome) 
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        // Métodos
        public abstract double TaxPayed();
    }
}