using System;

namespace Bank
{
    class Account
    {
        public UInt64 Id { get; private set; }
        public string Owner { get; set; }
        public UInt128 Balance { get; private set; }
        public const int Fee = 500;

        public Account(UInt64 id, string owner)
        {
            this.Id = id;
            this.Owner = owner;
        }

        public Account(UInt64 id, string owner, UInt128 balance) : this(id, owner)
        {
            Deposit(balance);
        }

        public bool Deposit(UInt128 amount)
        {
            if (this.Balance > UInt128.MaxValue - amount)
            {
                return false;
            }
            this.Balance += amount;
            return true;
        }

        public bool Withdraw(UInt128 amount)
        {
            if (this.Balance < amount + Fee)
            {
                return false;
            }
            this.Balance -= amount + Fee;
            return true;
        }
    }
}