using System;

namespace View
{
    public static class GetDateTimeFormat
    {

        public static string GetDateFormat()
        {
            string year = DateTime.Now.Year > 9 ? DateTime.Now.Year.ToString() : "0" + DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month > 9 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day > 9 ? DateTime.Now.Day.ToString() : "0" + DateTime.Now.Day.ToString();

            return $"{day} / {month} / {year}";
        }
    }
}
