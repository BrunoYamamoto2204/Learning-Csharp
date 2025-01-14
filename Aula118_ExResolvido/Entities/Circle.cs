using Aula119_ExResolvido.Entities.Enum;

namespace Aula119_ExResolvido.Entities
{
    class Circle : Shape
    {
        // Atributos 
        public double Radius { get; set; }

        // Construtores 
        public Circle (double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        // Métodos
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}