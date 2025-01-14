using Aula119_ExResolvido.Entities.Enum;

namespace Aula119_ExResolvido.Entities
{
    abstract class Shape 
    {
        // Atributos 
        public Color Color { get; set; }

        // Construtores
        public Shape (Color color)
        {
            Color = color;
        }

        // Métodos
        public abstract double Area ();
    }
}