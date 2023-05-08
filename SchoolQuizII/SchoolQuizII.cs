using System;
using System.Collections.Generic;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class SchoolQuizII
    {
        #region YOUR CODE IS HERE

        #region FUNCTION#1: Calculate the Value
        //Your Code is Here:
        //==================
        /// <summary>
        /// find the minimum number of integers whose sum equals to ‘N’
        /// </summary>
        /// <param name="N">number given by the teacher</param>
        /// <param name="numbers">list of possible numbers given by the teacher (starting by 1)</param>
        /// <returns>minimum number of integers whose sum equals to ‘N’</returns>
        static public int SolveValue(int N, int[] numbers)
        {
            Array.Sort(numbers);
            List<int> sol = new List<int>();
            int min = int.MaxValue;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int n = N;
                int j = i;
                int cnt = 0, rem = 0;
                List<int> intgs = new List<int>();
                while (true)
                {
                    if (n >= numbers[j])
                    {
                        intgs.Add(numbers[j]);
                        cnt += n / numbers[j];
                        rem = n % numbers[j];
                        if (rem == 0) break;
                        n = rem;
                    }
                    j--;
                }
                if (min > cnt)
                {
                    min = cnt;
                    sol = intgs;
                }
            }
            return min;
        }
        #endregion

        #region FUNCTION#2: Construct the Solution
        //Your Code is Here:
        //==================
        /// <returns>the numbers themselves whose sum equals to ‘N’</returns>
        static public int[] ConstructSolution(int N, int[] numbers)
        {
            Array.Sort(numbers);
            List<int> sol = new List<int>();
            int min = int.MaxValue;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int n = N;
                int j = i;
                int cnt = 0, rem = 0;
                List<int> intgs = new List<int>();
                while (true)
                {
                    if (n >= numbers[j])
                    {
                        intgs.Add(numbers[j]);
                        cnt += n / numbers[j];
                        rem = n % numbers[j];
                        if (rem == 0) break;
                        n = rem;
                    }
                    j--;
                }
                if (min > cnt)
                {
                    min = cnt;
                    sol = intgs;
                }
            }
            return sol.ToArray();
        }
        #endregion

        #endregion
    }
}
