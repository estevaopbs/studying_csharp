using System.Globalization;
using ReadOrder.Entities;
using ReadOrder.Entities.Enums;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(name));
Console.Write("Email: ");
string email = Console.ReadLine() ?? throw new ArgumentNullException(nameof(email));
Console.Write("Birth Date (yyyy-mm-dd): ");
DateTime birthDate = DateTime.ParseExact(Console.ReadLine() ?? throw new ArgumentNullException(nameof(birthDate)), "yyyy-mm-dd", CultureInfo.InvariantCulture);
Client client = new Client(name, email, birthDate);
Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine() ?? throw new ArgumentNullException(nameof(status)));
Console.Write("How many items to this order: ");
int quantity = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(nameof(quantity)));
List<OrderItem> orderItems = new List<OrderItem>();
for (int i = 0; i < quantity; i++)
{
    Console.WriteLine("Enter #{0} item data:", i + 1);
    Console.Write("Product name: ");
    string productName = Console.ReadLine() ?? throw new ArgumentNullException(nameof(productName));
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(nameof(productPrice)));
    Console.Write("Quantity: ");
    int itemQuantity = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(nameof(itemQuantity)));
    orderItems.Add(new OrderItem(itemQuantity, new Product(productName, productPrice)));
}
Order order = new Order(orderItems, status, client);
Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine("Order moment: {0}", order.Moment.ToString("yyyy-MM-dd HH:mm:ss"));
Console.WriteLine("Order status: {0}", order.Status);
Console.WriteLine("Client: {0} ({1}) - {2}", order.Client.Name, order.Client.BirthDate.ToString("yyyy-mm-dd"), order.Client.Email);
Console.WriteLine("Order Items:");
foreach (OrderItem orderItem in order.Items)
{
    Console.WriteLine("{0}, {1:F2}, Quantity: {2}, Subtotal: ${3:F2}", orderItem.Product.Name, orderItem.Price, orderItem.Quantity, orderItem.Subtotal());
}
Console.WriteLine("Total price: ${0:F2}", order.Total());