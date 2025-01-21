
namespace Aula176_ExResolvindoLINQ.Enitites
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}

// Formato do arquivo \\
//TV,900.00
//Mouse,50.00
//Tablet,350.50
//HD Case,80.90
//Computer,850.00
//Monitor,290.00
