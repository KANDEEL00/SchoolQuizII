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
        static public int final_sol = int.MaxValue;
        static public KeyValuePair<int, int>[] sol_ints;
        static public int SolveValue(int N, int[] numbers)
        {
            sol_ints = new KeyValuePair<int, int>[N + 1];
            Array.Sort(numbers);
            int[] sol = new int[N + 1];
            foreach (int i in numbers) if (i <= N) sol[i] = 1;
            for (int i = 1; i <= N; i++)
            {
                if (sol[i] == 1) continue;
                sol[i] = int.MaxValue;
                int a = 1, b = i - 1;
                foreach (int intg in numbers)
                {
                    if (intg > i) break;
                    a = intg;
                    b = i - intg;
                    int tmp = sol[a] + sol[b];
                    if (tmp < sol[i])
                    {
                        sol[i] = tmp;
                        sol_ints[i] = new KeyValuePair<int, int>(a, b);
                    }
                }
            }
            final_sol = sol[N];
            return final_sol;
        }
        #endregion

        #region FUNCTION#2: Construct the Solution
        //Your Code is Here:
        //==================
        /// <returns>the numbers themselves whose sum equals to ‘N’</returns>
        static public int[] ConstructSolution(int N, int[] numbers)
        {
            int[] sol_arr = new int[final_sol];

            int i = 0;
            int n = N;
            while (sol_ints[n].Key != 0)
            {
                sol_arr[i] = sol_ints[n].Key;
                n = sol_ints[n].Value;
                i++;
            }
            sol_arr[i] = n;
            return sol_arr;
        }
        #endregion

        #endregion
    }
}
