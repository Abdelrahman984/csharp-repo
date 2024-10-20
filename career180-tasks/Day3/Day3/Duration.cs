using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Hours}H:{Minutes}M:{Seconds}S";
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) +
                               (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);

            return FromTotalSeconds(totalSeconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) -
                               (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);

            return FromTotalSeconds(totalSeconds);
        }

        public static bool operator ==(Duration d1, Duration d2)
        {
            return (d1.Hours == d2.Hours) && (d1.Minutes == d2.Minutes) && (d1.Seconds == d2.Seconds);
        }

        public static bool operator !=(Duration d1, Duration d2)
        {
            return !(d1 == d2);
        }

        public static bool operator <= (Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <=
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        public static bool operator >= (Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >=
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        private static Duration FromTotalSeconds(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            return new Duration(hours, minutes, seconds);
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration)
            {
                Duration d = (Duration)obj;
                return this == d;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Hours, Minutes, Seconds).GetHashCode();
        }
    }

}
