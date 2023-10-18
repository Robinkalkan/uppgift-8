using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uppgift_8;
internal class Program
{
    private static void Main(string[] args)
    {
        Stack<Employee> employeeStack = new Stack<Employee>();

        Employee employee1 = new Employee(100, "Christoffer", "Male", 50000);
        employeeStack.Push(employee1);

        Employee employee2 = new Employee(101, "Robin", "Male", 34900);
        employeeStack.Push(employee2);

        Employee employee3 = new Employee(102, "Kevin", "Male", 27899);
        employeeStack.Push(employee3);

        Employee employee4 = new Employee(103, "Amanda", "Female", 30000);
        employeeStack.Push(employee4);

        Employee employee5 = new Employee(104, "Eva", "Female", 33000);
        employeeStack.Push(employee5);

        Console.WriteLine("Alla objekt i stacken:");

        foreach (var employee in employeeStack)
        {
            Console.WriteLine($"ID: {employee.Id}, Namn: {employee.Name}, Kön: {employee.Gender}, Lön: {employee.Salary}");
            Console.WriteLine($"Antal objekt i stacken: {employeeStack.Count}");
        }
        Console.WriteLine("--------------------------");
        while (employeeStack.Count > 0)
        {
            Employee poppedEmployee = employeeStack.Pop();
            Console.WriteLine($"Id: {poppedEmployee.Id}, Namn: {poppedEmployee.Name}");
            Console.WriteLine($"Antal kvar i stacken: {employeeStack.Count}");
        }
        Console.WriteLine("----------------------------");
        employeeStack.Push(new Employee(100, "Christoffer", "Male", 50000));

        employeeStack.Push(new Employee(101, "Robin", "Malee", 34900));

        employeeStack.Push(new Employee(102, "Kevin", "Male", 27899));

        employeeStack.Push(new Employee(103, "Amanda", "Female", 30000));

        employeeStack.Push(new Employee(104, "Eva", "Female", 33000));

        Console.WriteLine("Hämtar två objekt med Peek-metoden:");
        Employee peekedEmployee1 = employeeStack.Peek();
        Console.WriteLine($"Peeked - ID: {peekedEmployee1.Id}, Namn: {peekedEmployee1.Name}");
        Console.WriteLine($"Antal objekt kvar i stacken: {employeeStack.Count}");

        Employee peekedEmployee2 = employeeStack.Peek();
        Console.WriteLine($"Peeked - ID: {peekedEmployee2.Id}, Namn: {peekedEmployee2.Name}");
        Console.WriteLine($"Antal objekt kvar i stacken: {employeeStack.Count}");
        Console.WriteLine("-------------------------------");
        bool containsEmployee3 = employeeStack.Any(i =>
           i.Id == 102 && i.Name == "Kevin" && i.Gender == "Male" && i.Salary == 27899);
        Console.WriteLine("\nInnehåller stacken objekt nummer 3? (id 102, Kevin, Male, 27899)? " + containsEmployee3);
        Console.WriteLine("--------------------------------");

        List<Employee> employeeList = new List<Employee>();

        employeeList.Add(new Employee(100, "Christoffer", "Male", 50000));
        employeeList.Add(new Employee(101, "Robin", "Male", 34900));
        employeeList.Add(new Employee(102, "Kevin", "Male", 27899));
        employeeList.Add(new Employee(103, "Amanda", "Female", 30000));
        employeeList.Add(new Employee(104, "Eva", "Female", 33000));

        Employee employeeFind = new Employee(102, "Kevin", "Male", 27899);
        if (employeeList.Contains(employeeFind))
        {
            Console.WriteLine("Employee2 object exists in the list");
        }
        else
        {
            Console.WriteLine("Employee2 object does not exist in the list");
        }

        Employee maleEmployee = employeeList.Find(emp => emp.Gender == "Male");
        if (maleEmployee != null)
        {
            Console.WriteLine($"First Male Employee: ID: {maleEmployee.Id}, Name: {maleEmployee.Name}");
        }

        List<Employee> maleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
        Console.WriteLine("All Male Employees:");
        foreach (var emp in maleEmployees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}");
        }
    }
    
}