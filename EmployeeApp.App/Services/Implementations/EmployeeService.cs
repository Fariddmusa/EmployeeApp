using EmployeeApp.App.Services.Interfaces;
using EmployeeApp.Core.Models;
using EmployeeApp.Data.Repositories;

namespace EmployeeApp.App.Services.Implementations
{
    internal class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _EmployeeRepository = new EmployeeRepository(); 
        public void Create()
        {
            Employee employee = new Employee();
            Console.WriteLine("Add name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Add surname");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("Add salary");
            employee.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Add position");
            employee.Position = Console.ReadLine();
            _EmployeeRepository.Create(employee);
        }

        public void Delete()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Employee employee = _EmployeeRepository.Get(id);
            if(employee == null)
            {
                Console.WriteLine("employee not found");
            }
            else
            {
                _EmployeeRepository.Delete(employee);
                Console.WriteLine("employee deleted");
            }
        }

        public void Get()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Employee employee = _EmployeeRepository.Get(id);
            if (employee == null)
            {
                Console.WriteLine("employee not found");
            }
            else
            {
                Console.WriteLine(employee);
            }
        }

        public void GetAll()
        {
            List<Employee> employees = _EmployeeRepository.GetAll();
            foreach(var item in employees)
            {
                Console.WriteLine(item);
            }
        }

        public void Update()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Employee employee = _EmployeeRepository.Get(id);
            if (employee == null)
            {
                Console.WriteLine("employee not found");
            }
            else
            {
                Console.WriteLine("Add name");
                employee.Name = Console.ReadLine();
            }
        }
    }
}
