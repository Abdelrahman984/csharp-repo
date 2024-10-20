using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment4
{
    public class Person
    {
        
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            // Constructor
            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            // Method to return basic details
            public virtual string GetDetails()
            {
                return $"Name: {FirstName} {LastName}, Age: {Age}";
            }
        

    }
}
