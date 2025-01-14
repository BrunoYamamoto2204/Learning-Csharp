using Aula119_ExResolvido.Entities.Enum;

namespace Aula119_ExResolvido.Entities
{
    class Rectangle : Shape
    {
        // Atributos 
        public double Width { get; set; }
        public double Height { get; set; }

        // Construtores 
        public Rectangle (double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        // Métodos
        public override double Area()
        {
            return Width * Height;
        }
    }
}