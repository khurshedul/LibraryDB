using Basics;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public class Program
{
    //private static void Main(string[] args)
    //{
    //    // Setup DI container

    //    var serviceProvider = new ServiceCollection()
    //        .AddSingleton<IEmployeeService, EmployeeService>()
    //        .BuildServiceProvider();

    //    // Resolve and use the service
    //    var service = serviceProvider.GetService<IEmployeeService>();



    //    //Employee Seed 

    //    List<Employee> dataBase = new List<Employee>
    //    {
    //        new Employee { ID = 1, Name = "John Doe", Dept = "IT" },
    //        new Employee { ID = 2, Name = "Jane Smith", Dept = "HR" },
    //        new Employee { ID = 3, Name = "Bob Johnson", Dept = "Finance" },
    //        new Employee { ID = 4, Name = "Alice White", Dept = "Marketing" },
    //        new Employee { ID = 5, Name = "Charlie Brown", Dept = "IT" },
    //        new Employee { ID = 6, Name = "Eva Green", Dept = "HR" },
    //        new Employee { ID = 7, Name = "Frank Miller", Dept = "Finance" },
    //        new Employee { ID = 8, Name = "Grace Lee", Dept = "Marketing" },
    //        new Employee { ID = 9, Name = "Harry Turner", Dept = "IT" },
    //        new Employee { ID = 10, Name = "Ivy Wang", Dept = "HR" },
    //    };
    //    dataBase = service.Add(new Employee
    //    {
    //        ID = 11,
    //        Dept = "IT .NET",
    //        Name = "Aman"
    //    }, dataBase);

    //    var name = service.GetEmployeeName(dataBase.First(s => s.ID == 1));

    //    dataBase = service.Delete(8, dataBase);

    //    var employee = service.Get(7, dataBase);

    //    foreach (var item in dataBase)
    //    {
    //        Console.WriteLine($"Employee Name {item.Name} Dept {item.Dept}");
    //    }


    //    EmployeeService emp = new EmployeeService();

    //    emp.Add(new Employee
    //    {
    //        Dept = "D",
    //        ID = 15,
    //        Name = "Name"
    //    }, dataBase);
    //}
}


