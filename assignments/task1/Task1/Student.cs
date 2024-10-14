namespace Task1
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public void print()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}
