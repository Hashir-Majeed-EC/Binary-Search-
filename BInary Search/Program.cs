using System;

namespace BInary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 5;
            nums[2] = 19;
            nums[3] = 24;
            nums[4] = 122;

            Console.WriteLine(binarySearch(nums, 24));
        }

        static string binarySearch(int[] nums, int val)
        {
            string output;
            int low = 0;
            int high = nums.Length - 1;
            int middle = (low + high) / 2;
            bool found = false;

            while (low <= high && found == false)
            {
                middle = (low + high) / 2;
                if (nums[middle] == val)
                {
                    found = true;
                } else if (nums[middle] > val)
                {
                    high = middle - 1;
                } else
                {
                    low = middle + 1;
                }
            }

            if (found == false)
            {
                output = "Value was not found in array.";
            }
            else
            {
                output = "Value " + val + " was found at position " + middle.ToString();
            }

            return output;
        }
    }
}
