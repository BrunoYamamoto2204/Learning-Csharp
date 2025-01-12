using Aula105_Fixacao.Entities.Enums;

namespace Aula105_Fixacao.Entities 
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();

        public Order (){}
        public Order (DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem (OrderItem order)
        {
            Orders.Add(order);
        }
        public void RemoveItem (OrderItem order)
        {
            Orders.Remove(order);
        }

        public double Total()
        {
            double totalValue = 0;

            foreach (OrderItem order in Orders)
            {
                totalValue += order.SubTotal();
            }

            return totalValue;
        }

        public override string ToString()
        {
           return $"Order moment: {Date}\nOrder status: {Status} \nClient: {Client}"+
                  "\n\nOrder items:";
        }
    }
}