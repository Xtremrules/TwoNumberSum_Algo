using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] output = TwoNumberSum2(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

			output.ToList().ForEach(x => Console.WriteLine(x));
			Console.ReadLine();
		}

		// 0(n) time || 0(n) Space
		public static int[] TwoNumberSum2(int[] array, int targetSum)
		{
			HashSet<int> nums = new HashSet<int>();
            foreach (int num in array)
            {
				int potentialMatch = targetSum - num;
				if (nums.Contains(potentialMatch))
                {
					return new int[] { potentialMatch, num };
				}
                else
                {
					nums.Add(num);
                }

            }
			return new int[0];
		}

		// 0(nlog(n)) time | 0(1) Space
		public static int[] TwoNumberSum3(int[] array, int targetSum)
		{
			Array.Sort(array);
			int left = 0;
			int right = array.Length - 1;
            while (left < right)
            {
				int sum = array[left] + array[right];
				if (sum == targetSum)
					return new int[] { array[left], array[right] };
				else if (sum < targetSum)
					left++;
				else if (sum > targetSum)
					right--;
            }
			return new int[0];
		}

		// 0(n^2) time | 0(1) Space
		public static int[] TwoNumberSum(int[] array, int targetSum)
		{
			// Write your code here.
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					if (array[i] + array[j] == targetSum)
					{
						return new int[2] { array[i], array[j] };
					}
				}
			}
			return new int[0];
		}
	}
}
