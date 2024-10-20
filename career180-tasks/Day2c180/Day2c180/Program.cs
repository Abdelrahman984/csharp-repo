using System;

public struct HireDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HireDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year}";
    }

    public int CompareTo(HireDate other)
    {
        if (Year != other.Year)
            return Year.CompareTo(other.Year);
        if (Month != other.Month)
            return Month.CompareTo(other.Month);
        return Day.CompareTo(other.Day);
    }
}

public class Employee : IComparable<Employee>
{
    public int ID { get; set; }
    public double Salary { get; set; }
    public string Gender { get; set; }
    public HireDate HireDate { get; set; }

    
    public Employee(int id, double salary, string gender, HireDate hireDate)
    {
        ID = id;
        Salary = salary;
        Gender = gender;
        HireDate = hireDate;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Salary: {Salary:C}, Gender: {Gender}, Hire Date: {HireDate}";
    }

    public int CompareTo(Employee other)
    {
        return this.HireDate.CompareTo(other.HireDate);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        Employee[] employees = new Employee[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter details for Employee {i + 1}:");

            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Gender (M/F): ");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter Hire Date (DD MM YYYY):");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            HireDate hireDate = new HireDate(day, month, year);

            employees[i] = new Employee(id, salary, gender, hireDate);
        }

        Array.Sort(employees);

        Console.WriteLine("\nEmployees sorted by hire date:");
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}
