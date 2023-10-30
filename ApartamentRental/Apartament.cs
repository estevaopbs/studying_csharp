namespace Apartament
{
    class Rental
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Name + ", " + Email;
        }

        public Rental(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}