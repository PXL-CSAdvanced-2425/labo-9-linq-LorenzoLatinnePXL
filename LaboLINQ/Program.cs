using System.Security.Cryptography.X509Certificates;

namespace LaboLINQ
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FullName = "Alice Janssens", Age = 30, DepartmentId = 1, Salary = 3500 },
                new Employee { Id = 2, FullName = "Bob Peeters", Age = 45, DepartmentId = 2, Salary = 4200 },
                new Employee { Id = 3, FullName = "Charlie Van Dijk", Age = 28, DepartmentId = 1, Salary = 3100 },
                new Employee { Id = 4, FullName = "Dina Maes", Age = 50, DepartmentId = 3, Salary = 5000 },
                new Employee { Id = 5, FullName = "Eva Willems", Age = 22, DepartmentId = 2, Salary = 2800 },
            };

            List<Department> departments = new List<Department>
            {
                new Department { Id = 1, Name = "Development" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Management" }
            };

            Console.WriteLine("Filter employees older than 30:");
            var employeesOlderThanThirty =
                employees.Where((x) => x.Age > 30).ToList();

            var employeesOlderThanThirty2 =
                from employee in employees
                where employee.Age > 30
                select employee;

            employeesOlderThanThirty.ForEach((x) =>
                Console.WriteLine
                    ($"Name: {x.FullName} - Age: {x.Age} - DepartmentId: {x.DepartmentId} - Salary: {x.Salary:c}"));
            Console.WriteLine();

            Console.WriteLine("Sort employees by their salary:");
            var employeesOrdered =
                employees.OrderByDescending(x => x.Salary)
                         .Select(x => $"Name: {x.FullName} \t Salary: {x.Salary:c}")
                         .ToList();

            var employeesOrdered2 =
                from employee in employees
                orderby employee.Salary descending
                select $"{employee.FullName} {employee.Salary}";

            employeesOrdered.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Sort employees by their department and age.");
            var employeesOrderedByDepartmentAndAge =
                employees.OrderBy(x => x.Age)
                .ThenBy(x => x.DepartmentId)
                .Select(x => 
                    $"DepartmentId: {x.DepartmentId} Full name: {x.FullName} Age: {x.Age}")
                .ToList();

            employeesOrderedByDepartmentAndAge.ForEach((x) => Console.WriteLine(x));

            Console.WriteLine();


            Console.WriteLine("Group employees by their department:");
            var employeesByDepartment =
                employees.GroupBy(x => x.DepartmentId);

            var employeesByDepartment2 =
                from employee in employees
                group employee by employee.DepartmentId;

            foreach (var group in employeesByDepartment)
            {
                int count = 0;
                foreach (var employee in group)
                {
                    count++;
                }
                Console.WriteLine($"DepartementId: {group.Key} - Aantal medewerkers: {count}");
            }
        }
    }
}