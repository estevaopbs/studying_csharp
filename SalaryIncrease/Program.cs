using Company;

Console.Write("How many employes do you register? ");
ushort n = ushort.Parse(Console.ReadLine() ?? throw new ArgumentNullException(nameof(n)));
Console.WriteLine();
List<Employee> employees = new List<Employee>();
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Employee {0}:", i);
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(name));
    Console.Write("Salary: ");
    float salary = float.Parse(Console.ReadLine() ?? throw new ArgumentNullException(nameof(salary)));
    employees.Add(new Employee(name, salary));
    Console.WriteLine();
}

Console.WriteLine("Choose an employee by Id to have their salary increased: ");
ushort employeesID = ushort.Parse(Console.ReadLine() ?? throw new ArgumentNullException(nameof(employeesID)));
Employee employee = employees.Find(x => x.Id == employeesID) ?? throw new ArgumentNullException(nameof(employee));
Console.Write("Enter the percentage of salary increase: ");
float currentSalary = employee.Salary;
float percentage = float.Parse(Console.ReadLine() ?? throw new ArgumentNullException(nameof(percentage)));
employee.IncreaseSalary(percentage);
Console.WriteLine("{0}'s salary updated from {1} to {2} successfully!", employee.Name, currentSalary, employee.Salary);

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employee employee1 in employees)
{
    Console.WriteLine("{0}, {1}, {2}", employee1.Id, employee1.Name, employee1.Salary);
}