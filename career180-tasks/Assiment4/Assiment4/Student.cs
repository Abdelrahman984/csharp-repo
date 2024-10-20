using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment4
{
    public class Student : Person
    {
        public int StudentID { get; set; }
        public double GPA { get; set; }

        // Constructor
        public Student(string firstName, string lastName, int age, int studentID, double gpa)
            : base(firstName, lastName, age)
        {
            StudentID = studentID;
            GPA = gpa;
        }

        // Override GetDetails to include Student ID and GPA
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Student ID: {StudentID}, GPA: {GPA}";
        }

        // Overloaded GetDetails method with boolean parameter
        public string GetDetails(bool includeGPA)
        {
            if (includeGPA)
            {
                return GetDetails(); // Calls the overridden method with GPA
            }
            else
            {
                return $"{base.GetDetails()}, Student ID: {StudentID}";
            }
        }
    }

}
