using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Diagonals
    {
        public void Calculate()
        {
            int[][] values = new int[][] { new[] { 11, 2, 4 }, new[] { 4, 5, 6 }, new[] { 10, 8, -12 } };

            int sumOfFirstDim = 0;
            int sumOfSecondDim = 0;
            for (int i = 0, j = values.Length - 1; i < values.Length; ++i, --j)
            {
                sumOfFirstDim += values[i][i];
                sumOfSecondDim += values[i][j];
            }

            var result = Math.Abs(sumOfFirstDim - sumOfSecondDim);
        }
    }
}
