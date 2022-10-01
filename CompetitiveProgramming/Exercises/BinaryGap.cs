using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgrammingExs.Exercises
{
    public class BinaryGap
    {
        public static int Solution(int N)
        {
            if (N >= int.MaxValue || N <= 4)
            {
                return 0;
            }

            char[] bitArray = Convert.ToString(N, 2).ToCharArray();

            List<int> binaryGaps = new List<int>() { 0 };
            int binaryGapCount = 0;

            bool end;

            for (int i = 0; i < bitArray.Length; i++)
            {
                end = bitArray[i] == '1';

                if (end && binaryGapCount > 0)
                {
                    binaryGaps.Add(binaryGapCount);
                    binaryGapCount = 0;
                }
                else if (!end)
                {
                    binaryGapCount++;
                }
            }

            return binaryGaps.Max();
        }
    }
}
