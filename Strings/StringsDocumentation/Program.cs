// How to deal with strings in cs
using System;
using System.Formats;
using System.Reflection.Metadata;

namespace Strings
{
    class Program
    {
        public static void Main(string[] args)
        {
            // This will print the number which is refered by {0}, and the currency
            // prints -- $120.34
            string myString = string.Format("{0:C}", 120.34);
            print(myString);
            
            // This is a good way for concatination of strings
            string format = string.Format("{0} canTypehereorleave {1}", "First", "Second");
            print(format);
            
            // Formats long nums
            //will print 123,121,231,200.000
            string longNumFormat = string.Format("{0:N}", 123121231200);
            print(longNumFormat);
            
            // show number as percentage
            // This will print ( The percentage is: 12.300%)
            string percentNum = string.Format(" The percentage is: {0:P}", .123);
            print(percentNum);
            
            // This will start from index 5 => zero based
            string mySub = " This shows you an example of a built-in sub function in c# ";
            mySub = mySub.Substring(6);
            print(mySub);
        }

        private static void print(string myString)
        {
            Console.WriteLine(myString);
        }
    }
}

