using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var sum = A.Sum();
            for (var i = 0; i < A.Length; i++)
            {
                var sumLeft = A.Take(i + 1).Sum();
                var sumRight = sum - sumLeft - A[i + 1];
                if (sumLeft == sumRight)
                {
                    return i + 1;
                }
            }
            return -1;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            Console.WriteLine( new Solution().solution(A));
        }
    }
}
