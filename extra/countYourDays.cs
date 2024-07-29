using System;

namespace extra
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime myBirth = DateTime.Parse("2004/3/1");
            TimeSpan myAge = DateTime.Now.Subtract(myBirth);
            Console.WriteLine(myAge.Days);
        }
    };
}

