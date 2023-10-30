using System;
using Bank;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Id: ");
        UInt64 id = UInt64.Parse(Console.ReadLine());
        Console.Write("Do you want to insert an initial deposit (y/n): ");
        char init_dp_inp = char.Parse(Console.ReadLine());
        Account account = null;
        switch (init_dp_inp)
        {
            case 'y':
                Console.Write("Amount: ");
                UInt128 amount = UInt128.Parse(Console.ReadLine());
                account = new Account(id, name, amount);
                break;
            case 'n':
                account = new Account(id, name);
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
        if (account != null)
        {
            Console.Write("Deposit: ");
            UInt128 deposit = UInt128.Parse(Console.ReadLine());
            bool success = account.Deposit(deposit);
            if (success)
            {
                Console.WriteLine("Deposit successful\nCurrent Balance: {0}", account.Balance);
            }
            else
            {
                Console.WriteLine("Deposit unsuccessful.");
            }
            Console.Write("Withdraw: ");
            UInt128 withdraw = UInt128.Parse(Console.ReadLine());
            success = account.Withdraw(withdraw);
            if (success)
            {
                Console.WriteLine("Withdraw successful\nCurrent Balance: {0}", account.Balance);
            }
            else
            {
                Console.WriteLine("Withdraw unsuccessful.");
            }
            Console.WriteLine("Updated account information:\nId: {0}\nName: {1}\nBalance: {2}", account.Id, account.Owner, account.Balance);
        }
    }
}