using System;
using System.Globalization;
using System.Threading;

namespace DateMod
{
    public class DateModifier
    {
        private int daysBetween;

        public int DaysBetween
        {
            get { return this.daysBetween; }
            set { this.daysBetween = value; }
        }

        public void CalculateDifference(string firstDate, string secondDate)
        {
            var dateOne = Convert.ToDateTime(firstDate);
            var dateTwo = Convert.ToDateTime(secondDate);

            this.DaysBetween = (int)Math.Abs((dateOne - dateTwo).TotalDays);
        }
    }
}