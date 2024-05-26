using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string source)
        {
            return source == null  || !source.Any();
        }
    }
}
