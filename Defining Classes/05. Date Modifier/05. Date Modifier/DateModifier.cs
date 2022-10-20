using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Date_Modifier
{
    public static class DateModifier
    {
        public static int DateDifference(string startDateAsString, string endDateAsString)
        {
            DateTime startDate = DateTime.Parse(startDateAsString);
            DateTime endDate = DateTime.Parse(endDateAsString);

            TimeSpan difference = endDate - startDate;

            return difference.Days;
        }
    }
}
