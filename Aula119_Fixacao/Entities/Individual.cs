namespace Aula119_Fixacao.Entities
{
    class Individual : TaxPayer
    {
        // Atributos 
        public double HealthExpeditures { get; set; }

        // Construtores 
        public Individual (string name, double anualIncome, double healthExpeditures) 
            : base (name, anualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }

        // Métodos
        public override double TaxPayed()
        {
            if (AnualIncome < 20000){
                return AnualIncome * 0.15 - (HealthExpeditures * 0.5);
            }
            else{
                return AnualIncome * 0.25 - (HealthExpeditures * 0.5);
            }
        }
    }
}