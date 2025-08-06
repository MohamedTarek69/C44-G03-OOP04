using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Part_02_Class
{
    internal class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Constructors
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
        public Duration()
        {

        }

        #endregion

        #region Methods
        public override string ToString()
        {
            string result = "";
            if (Hours > 0) 
                result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0) 
                result += $"Minutes: {Minutes}, ";
            if (Seconds > 0 || Minutes > 0 || Hours > 0)
                result += $"Seconds: {Seconds}";
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration D1)
            {
                return Hours == D1.Hours &&
                       Minutes == D1.Minutes &&
                       Seconds == D1.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        private int TotalSeconds()
        {
            return (Hours * 3600) + (Minutes * 60) + Seconds;
        }
        #endregion

        #region Operators Overloading
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration(left.TotalSeconds() + right.TotalSeconds());
        }

        public static Duration operator +(Duration left, int seconds)
        {
            return new Duration(left.TotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration(d1.TotalSeconds() + seconds);
        }

        public static Duration operator ++(Duration d1)
        {
            return new Duration(d1.TotalSeconds() + 60);
        }

        public static Duration operator --(Duration d1)
        {
            return new Duration(d1.TotalSeconds() - 60);
        }

        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration(left.TotalSeconds() - right.TotalSeconds());
        }

        public static bool operator >(Duration left, Duration right)
        {
            return left.TotalSeconds() > right.TotalSeconds();
        }

        public static bool operator <(Duration left, Duration right)
        {
            return left.TotalSeconds() < right.TotalSeconds();
        }

        public static bool operator <=(Duration left, Duration right)
        {
            return left.TotalSeconds() <= right.TotalSeconds();
        }

        public static bool operator >=(Duration left, Duration right)
        {
            return left.TotalSeconds() >= right.TotalSeconds();
        }

        public static bool operator true(Duration d1)
        {
            return d1.TotalSeconds() > 0;
        }

        public static bool operator false(Duration d1)
        {
            return d1.TotalSeconds() <= 0;
        }

        public static explicit operator DateTime(Duration d1)
        {
            return new DateTime().AddHours(d1.Hours).AddMinutes(d1.Minutes).AddSeconds(d1.Seconds);
        }

        #endregion
    }
}

