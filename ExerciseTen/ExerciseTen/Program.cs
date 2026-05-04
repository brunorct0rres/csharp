using ExerciseTen;
using System.Globalization;

Console.Write("How many employees will be registered? ");
int employeeQuantity = int.Parse(Console.ReadLine());

List<Employee> employeeList = new List<Employee>();

for (int i = 0; i < employeeQuantity; i++)
{
    Console.WriteLine($"Employee #{i + 1}");

    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Employee employee = new Employee(id, name);

    employee.SetInitialSalary(salary);

    employeeList.Add(employee);

    Console.WriteLine();
}

Console.Write("Enter the employee ID that will have salary increase: ");
int employeeIdToIncreaseSalary = int.Parse(Console.ReadLine());

Employee employeeToIncreaseSalary = employeeList.Find(x => x.Id == employeeIdToIncreaseSalary);

if (employeeToIncreaseSalary != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employeeToIncreaseSalary.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This ID does not exist!");
}

Console.WriteLine();

Console.WriteLine("Updated list of employees:");

foreach (Employee employee in employeeList)
{
    Console.WriteLine(employee);
}