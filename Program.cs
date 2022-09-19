namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Tamcore = new Company("Tamcore", DateTime.Now);

            Employee Jill = new Employee()
            {
                FirstName = "Jill",
                LastName = "Mayhew",
                Title = "Heavy Machinist",
                StartDate = DateTime.Now
            };
            Tamcore.EnrollEmployee(Jill);

            Employee Nils = new Employee()
            {
                FirstName = "Nils",
                LastName = "Forsyth",
                Title = "Engineer",
                StartDate = DateTime.Now
            };
            Tamcore.EnrollEmployee(Nils);

            Employee Peanut = new Employee()
            {
                FirstName = "Peanut",
                LastName = "Wilkerson",
                Title = "Hydrologic Mechanic",
                StartDate = DateTime.Now
            };
            Tamcore.EnrollEmployee(Peanut);

            Tamcore.ListEmployees();
        }
    }
}
