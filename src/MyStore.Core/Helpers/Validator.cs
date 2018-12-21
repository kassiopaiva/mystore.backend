using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Core.Helpers
{
    public static class Validator
    {
        public static bool StringMinLengthIsValid(string target, int minLength)
        {
            return target.Length >= minLength;
        }

        public static bool StringMaxLengthIsValid(string target, int maxLength)
        {
            return target.Length <= maxLength;
        }

        public static bool StringLengthIsValid(string target, int minLength, int maxLength)
        {
            return StringMinLengthIsValid(target, minLength)
                && StringMaxLengthIsValid(target, maxLength);
        }

        public static bool DecimalGreaterThan(decimal target, decimal minValue)
        {
            return target > minValue;
        }
    }
}
