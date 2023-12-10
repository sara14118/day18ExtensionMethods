using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18ExtensionMethod
{
    internal static class IntegerMirror
    {
        public static int Mirror (this int number)
        {
            int result = 0, remainder;

            while (number != 0) {

                remainder = number % 10;
                result = result * 10 + remainder;
                number = number / 10;
            }
            return result;

           



        }
    }
}
