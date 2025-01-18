
namespace Aula155_ExResolvido.Entities
{
    class LogRegister
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public LogRegister ( string name, DateTime date) {
            Name = name;
            Date = date;
        }

        public override int GetHashCode()
        {   
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is LogRegister)){
                return false;
            }

            LogRegister other = obj as LogRegister;
            return Name.Equals(other.Name);
        }
    }
}
