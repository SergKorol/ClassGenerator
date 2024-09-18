using ClassGenerator.Templates.Models;

namespace ClassGenerator;

internal static class Program
{
    private static void Main()
    {
        var employeeRepository = new Templates.Employee.DataRepository<Employee>();
        var userRepository = new Templates.User.DataRepository<User>();
        
        var employeeService = new Templates.Employee.DataService<Employee>(employeeRepository);
        var userService = new Templates.User.DataService<User>(userRepository);
        
        var employee = employeeService.Get();
        var user = userService.Get();
        
        
        Console.WriteLine("Employee:");
        Console.WriteLine($"Id: {employee.Id}");
        Console.WriteLine($"Name: {employee.Name}");
        Console.WriteLine($"Hired: {employee.Hired}");
        
        Console.WriteLine("\nUser:");
        Console.WriteLine($"Id: {user.Id}");
        Console.WriteLine($"Name: {user.Name}");
        Console.WriteLine($"Registered: {user.Registered}");
    }
}