namespace Company
{
    class Employee
    {
        private static ushort lastId = 0;
        public ushort Id { get; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public Employee(string name, float salary)
        {
            lastId++;
            Id = lastId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Salary = salary;
        }

        public void IncreaseSalary(float percentage)
        {
            if (percentage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage));
            }
            Salary += Salary * percentage / 100;
        }
    }
}