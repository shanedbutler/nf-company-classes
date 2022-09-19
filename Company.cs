namespace classes
{
    public class Company
    {
        public DateTime DateFounded { get; }
        public string Name { get; }
        public List<Employee> Employees = new List<Employee>();

        public Company(string name, DateTime date)
        {
            this.Name = name;
            this.DateFounded = date;
        }

        public void EnrollEmployee(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public void ListEmployees()
        {
            Console.WriteLine($"Employees at {this.Name}: ");

            foreach (Employee employee in this.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}
