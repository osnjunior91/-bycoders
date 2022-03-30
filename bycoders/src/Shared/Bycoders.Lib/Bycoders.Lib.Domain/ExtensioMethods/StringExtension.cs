using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bycoders.Lib.Bycoders.Lib.Domain.ExtensioMethods
{
    public static class StringExtension
    {
        public static DateTime CNABDate(this string str, string hour)
        {
            return new DateTime(int.Parse(str.Substring(0,4)), int.Parse(str.Substring(4, 2)), int.Parse(str.Substring(6, 2)), int.Parse(hour.Substring(0, 2)), int.Parse(hour.Substring(2, 2)), int.Parse(hour.Substring(4, 2)));
        }
    }
}
