using EmployeeApp.App.Services.Implementations;
using EmployeeApp.App.Services.Interfaces;

IEmployeeService employeeService= new EmployeeService();    

string Request=Console.ReadLine();

while (Request != "0")
{
    switch (Request)
    {
        case "1":
            employeeService.Create();
           break;
        case "2":
            employeeService.Update();
            break;
        case "3":
            employeeService.Delete();
            break;
        case "4":
            employeeService.GetAll();
            break;
        case "5":
            employeeService.Get();
            break;
        default:
            Console.WriteLine("select valid option");
            break;
    }

    Console.WriteLine("0.Close");
    Console.WriteLine("1.Employee Create");
    Console.WriteLine("2.Employee Update");
    Console.WriteLine("3.Employee Delete");
    Console.WriteLine("4.Employee ShowAll");
    Console.WriteLine("5.Employee Show");

    Request = Console.ReadLine();
}