using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.Utilities
{
    public static class Utils
    {
        public static string MiladiToShamsi(this DateTime date)
        {

            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date).ToString("0000")}/{pc.GetMonth(date).ToString("00")}/{pc.GetDayOfMonth(date)} " +
                   $"{pc.GetHour(date).ToString("00")}:{pc.GetMinute(date).ToString("00")}";
        }
    }
}
