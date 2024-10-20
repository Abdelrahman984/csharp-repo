using Day5c180;
using System;
class Program
{
    static void Main()
    {
        Employee employee = new Employee("Addullah ", 11);
        Employee employee1 = new Employee("Mohamed ", 14);

        Club club = new Club();
        SocialInsurance socialInsurance = new SocialInsurance();

        employee.EmployeeAdded += club.OnEmployeeAdded;
        employee.EmployeeAdded += socialInsurance.OnEmployeeAdded; 
        employee1.EmployeeAdded += club.OnEmployeeAdded;
        employee1.EmployeeAdded += socialInsurance.OnEmployeeAdded;

        employee.Add();
        employee1.Add();
    }
}
