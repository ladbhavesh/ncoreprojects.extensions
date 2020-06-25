using System;
using System.Collections.Generic;
using System.Text;

namespace NCoreProjects.Extensions
{
    public static class DateTimeExtension
    {
        public static bool IsWeekend(this DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsMaxDate(this DateTime dateTime)
        {
            return dateTime == DateTime.MaxValue;
        }

        public static bool IsMinDate(this DateTime dateTime)
        {
            return dateTime == DateTime.MinValue;
        }

        
    }
}
