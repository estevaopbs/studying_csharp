namespace ReadOrder.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; private set; }

        public double Price
        {
            get { return Product.Price; }
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double Subtotal()
        {
            return Quantity * Price;
        }
    }
}