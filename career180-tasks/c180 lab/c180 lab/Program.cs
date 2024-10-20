using System;

public class Duration
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Duration(int totalSeconds)
    {
        Hours = totalSeconds / 3600;
        totalSeconds %= 3600;
        Minutes = totalSeconds / 60;
        Seconds = totalSeconds % 60;
    }

    public string GetString()
    {
        string result = "";
        if (Hours > 0)
        {
            result += $"Hours: {Hours}, ";
        }
        if (Minutes > 0 || Hours > 0)
        {
            result += $"Minutes: {Minutes}, ";
        }
        result += $"Seconds: {Seconds}";
        return result;
    }
}

class Program
{
    static void Main()
    {
        Duration D1 = new Duration(1, 10, 15);
        Console.WriteLine(D1.GetString()); 

        Duration D2 = new Duration(3600);
        Console.WriteLine(D2.GetString()); 

        Duration D3 = new Duration(7800);
        Console.WriteLine(D3.GetString()); 

        Duration D4 = new Duration(666);
        Console.WriteLine(D4.GetString()); 
    }
}
