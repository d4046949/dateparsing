using System;
using System.Text;

namespace DateOrdering
{
    public class DateConversion
    {
        public static int GetDaysBetween(DateTime from, DateTime to)
        {
            return (int)(to - from).TotalDays;
        }


        public static int GetMonthsBetween(DateTime from, DateTime to)
        {
            return (int)to.Month - from.Month;
        }

        public static int GetYearsBetween(DateTime from, DateTime to)
        {
            return (int)to.Year - from.Year;
        }

        public static string GetDetails(DateTime from, DateTime to, string text = "")
        {
            if(from > to)
            {
                return GetDetails(to, from, text);
            }
            StringBuilder sb = new StringBuilder(text);

            var years = GetYearsBetween(from, to);

            if (years > 0)
            {
                sb.Append($"Years : {years}");
                var newFrom = new DateTime((from.Year + (int)years), from.Month, from.Day);
                return GetDetails(newFrom, to, sb.ToString());
            }

            var months = GetMonthsBetween(from, to);

            if (months > 0)
            {
                sb.Append($"{Environment.NewLine} Months : {months}");
                var newFrom = new DateTime(from.Year, (from.Month + months) , from.Day);
                return GetDetails(newFrom, to, sb.ToString());
            }

            var days = GetDaysBetween(from, to);

            sb.Append($"{Environment.NewLine} Days : {days}");

            return sb.ToString();
        }
    }
}
