
using System.Reflection.PortableExecutable;

namespace Aula156_ExConjuntos.Entities
{
    class Students
    {
        public int Number { get; set; }


        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Students)){
                return false;
            };

            Students other = obj as Students;
            return Number.Equals(other.Number);
        }
    }
}
