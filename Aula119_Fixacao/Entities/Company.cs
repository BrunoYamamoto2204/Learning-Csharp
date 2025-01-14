namespace Aula119_Fixacao.Entities
{
    class Company : TaxPayer
    {
        // Atributos
        public int Employees { get; set; }

        // Construtores 
        public Company (string name, double anualIncome, int employees) 
            : base(name,anualIncome)
        {
            Employees = employees;
        }

        // Métodos 
        public override double TaxPayed()
        {
            if (Employees > 10){
                return AnualIncome * 0.14;
            }
            else{
                return AnualIncome * 0.16;
            }

        }

    }
}