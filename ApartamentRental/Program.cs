using Apartament;

Console.Write("How many apartaments will be rented? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Rental[] rentals = new Rental[10];
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Rent #{0}:", i);
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int room = int.Parse(Console.ReadLine());
    if (rentals[room] != null)
    {
        Console.WriteLine("Room already occupied.");
        break;
    }
    rentals[room] = new Rental(name, email);
    Console.WriteLine();
}

Console.WriteLine("Busy rooms:");
for (int i = 0; i < 10; i++)
{
    Rental rental = rentals[i];
    if (rental != null)
    {
        Console.WriteLine("{0}: {1}, {2}", i, rental.Name, rental.Email);
    }
}
