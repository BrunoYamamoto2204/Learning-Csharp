namespace Aula136_ExFixacao.Entities
{
    class Product 
    {   
        // Atributos
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Construtores
        public Product(){}
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Métodos
        public double TotalPrice()
        {
            return Price * Quantity;
        }
    }
}