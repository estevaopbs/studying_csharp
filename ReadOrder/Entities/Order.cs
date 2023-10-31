using ReadOrder.Entities.Enums;

namespace ReadOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; private set; }
        public Client Client { get; private set; }

        public Order(List<OrderItem> items, OrderStatus status, Client client)
        {
            Moment = DateTime.UtcNow;
            Status = status;
            Items = items;
            Client = client;
        }

        public Order(OrderItem item, OrderStatus status, Client client)
        {
            Moment = DateTime.UtcNow;
            Status = status;
            Items = new List<OrderItem> { item };
            Client = client;
        }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.UtcNow;
            Status = status;
            Items = new List<OrderItem>();
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void AddItem(List<OrderItem> items)
        {
            Items.AddRange(items);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public void RemoveItem(List<OrderItem> items)
        {
            Items.RemoveAll(items.Contains);
        }

        public double Total()
        {
            return Items.Sum(item => item.Subtotal());
        }
    }
}