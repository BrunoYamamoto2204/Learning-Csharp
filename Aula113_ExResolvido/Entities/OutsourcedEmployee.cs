namespace Aula113_ExResolvido.Entities
{
    class OutsourcedEmployee : Employee
    {   
        // Atributos
        public double AdditionalCharge { get; set; }

        // Contrutores
        public OutsourcedEmployee (){}
        public OutsourcedEmployee (string name, int hours, double valuePerHour, double additionalCharge) 
            : base (name, hours, valuePerHour) 
        {
            AdditionalCharge = additionalCharge;
        }

        // Métodos
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }


    }
}