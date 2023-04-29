using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Classes
{
    internal static class Validator
    {
        public static double AssertOnPositiveValue(double value)
        {
            if (value >= 0.0)
            {
                return value;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));
            }
        }
        public static int AssertOnPositiveValue(int value)
        {
            if (value >= 0)
            {
                return value;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));
            }
        }
        public static int AssertValueInRange(int value)
        {
            if (value >= 0 && value <= 23)
            {
                return value;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));
            }
        }
    }
}
