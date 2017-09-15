using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class DateHandler
    {
        public int DaysBetweenDates(DateTime firstDate, DateTime secondDate)
        {
            return(secondDate - firstDate).Days;
        }

        public DateTime Add1000Days(DateTime theDate)
        {
            //return DateTime.Now;
            DateTime plus = theDate.AddDays(1000);
            return plus;
        }
    }
}
