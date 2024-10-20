using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5c180
{
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public delegate void EmployeeAddedHandler(string employeeName);

        public event EmployeeAddedHandler EmployeeAdded;

        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public void Add()
        {
            Console.WriteLine($"Adding employee {Name} with ID {ID} to the company.");

            if (EmployeeAdded != null)
            {
                EmployeeAdded(Name); 
            }
        }
    }

}
