using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class Calculator
    {
        public static System.IFormatProvider number { get; private set; }

        public static int Add(string numbers)
        {
            // Demo-1
            //step-1 - throw noimplementedexception
            //throw new NotImplementedException();

            //step-2 - make sure it builds successfully
            // return -1;

            //step-3 - return 0 value to make test pass
            // return 0 ;

            //step-4 - Add another test to return a different value

            //if (numbers == string.Empty)
            //    return 0;

            //if (numbers == "1, 2, 3")
            //    return 6;

            //if (numbers.Contains(','))
            //    return 15;

            //int.TryParse(numbers, outint result);
            //return result;

            //return 5;


            //Demo-2

            //var parts = numbers.Split(',');
            //var result = 0;

            //foreach (var part in parts)
            //{

            //    int.TryParse(part, out int number);

            //    if (number <= 1000)
            //        result += number;
            //}

            //return result;


            //Demo-3
            var parts = numbers.Split(',');
            var result = 0;
            var negatives = new List<int>();

            foreach (var part in parts)
            {
                int.TryParse(part, out int number);

                if (number < 0)
                    negatives.Add(number);
                else if(number <= 1000)
                    result += number;
            }

            if (negatives.Count > 0)
            {
                var negativesList = string.Join(',', negatives);
                var exceptionMessage = $"Negative numbers not allowed: {negativesList}.";
                throw new ArgumentException(exceptionMessage);
            }

            return result;
        }
    }

  }
