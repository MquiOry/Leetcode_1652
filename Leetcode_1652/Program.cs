using System;

namespace Leetcode_1652
{
    class Program
    {
        static void Main()
        {
            Solution solution = new Solution();

            int[] array = new int[] { 2, 4, 9, 3 };

            solution.Decrypt(array, -2);

            foreach(var value in array)
                Console.WriteLine(value);
        }
    }
}