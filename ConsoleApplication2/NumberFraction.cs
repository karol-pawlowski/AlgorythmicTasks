using System;

namespace ConsoleApplication2
{
    public class NumberFraction
    {
        public void Calculate()
        {
            int[] values = { -4, 3, -9, 0, 4, 1, };

            var negative = 0;
            var positive = 0;
            var zeros = 0;

            foreach (var value in values)
            {
                if (value < 0)
                    ++negative;
                if (value > 0)
                    ++positive;
                if (value == 0)
                    ++zeros;
            }

            if (values.Length == 0)
            {
                Console.WriteLine("0");
                Console.WriteLine("0");
                Console.WriteLine("0");
            }

            Console.WriteLine((positive / (double)values.Length).ToString("0.000000"));
            Console.WriteLine((negative / (double)values.Length).ToString("0.000000"));
            Console.WriteLine((zeros / (double)values.Length).ToString("0.000000"));
        }
    }
}
