namespace Assiment4
{
    internal class Program
    {
        public enum Grade
        {
            A,
            B,
            C,
            D,
            F
        }
        public static void AssignGrade(Student student)
        {
            bool isValidGrade = false;

            while (!isValidGrade)
            {
                Console.WriteLine("Enter grade (A, B, C, D, F):");
                string input = Console.ReadLine();

                // Try parsing the input to match enum values
                if (Enum.TryParse(input, true, out Grade grade) && Enum.IsDefined(typeof(Grade), grade))
                {
                  //  student.StudentGrade = grade;
                    isValidGrade = true;
                }
                else
                {
                    Console.WriteLine("Invalid grade. Please enter a valid grade (A, B, C, D, F).");
                }
            }

            Console.WriteLine($"Student {student.FirstName} {student.LastName} has been assigned grade:");
        }

        //public void UpdateStudentInfoByValue(int studentID, double newGPA)
        //{
        //    studentID = 99999; // Attempt to change studentID
        //    newGPA = 4.0; // Attempt to change GPA
        //                  // Since these are passed by value, the original values outside this method will not be affected.
        //}
        public void UpdateStudentInfoByReference(ref Student student, double newGPA)
        {
            student.GPA = newGPA; // This will modify the original object as it is passed by reference
        }
        public static void UpdateStudentInfoByValue (int studentID, double newGPA)
        {
            const int originalStudentID = 12345;
            // Creating a new student object inside the method (simulates value-type behavior)
            Student student = new Student("Mark", "Lee", 22, originalStudentID, 3.4);
            student.StudentID = studentID;
            student.GPA = newGPA;
            Console.WriteLine($"Inside UpdateStudentInfoByValue - GPA: {student.GPA}");
        }


        static void Main(string[] args)
        {
            // Creating a Person object
            Person person = new Person("John", "Doe", 45);
            Console.WriteLine(person.GetDetails());

            // Creating a Student object
            Student student = new Student("Jane", "Smith", 20, 12345, 3.75);
            Console.WriteLine(student.GetDetails()); // Calls the overridden method

            // Testing overloaded GetDetails method
            Console.WriteLine(student.GetDetails(true));  // Includes GPA
            Console.WriteLine(student.GetDetails(false)); // Excludes GPA


            Student student1 = new Student("Mark", "Lee", 22, 12345, 3.4);
            Console.WriteLine($"Before UpdateStudentInfoByValue - GPA: {student1.GPA}");

            // Call the method that passes the value by value
            UpdateStudentInfoByValue(student1.StudentID, 4.0);

            // GPA remains unchanged
            Console.WriteLine($"After UpdateStudentInfoByValue - GPA: {student1.GPA}");
        }
    }
    }

