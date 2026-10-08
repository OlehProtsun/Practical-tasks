using System.Globalization;
using System.Numerics;
using System.Xml;
using System.Xml.Linq;

namespace LeetCode_Task26
{
    internal class Program
    {
        //Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.The relative order of the elements should be kept the same.

        //Consider the number of unique elements in nums to be k​​​​​​​​​​​​​​. After removing duplicates, return the number of unique elements k.

        //The first k elements of nums should contain the unique numbers in sorted order. The remaining elements beyond index k - 1 can be ignored.
        static void Main(string[] args)
        {

        }

        public static int RemoveDuplicates(int[] nums)
        {
            //------------------1---------------------
            ////base case
            //if(nums is null)
            //{
            //    return 0;
            //}

            //int k = 1;

            //for (int i = 1; i < nums.Length; i++) 
            //{
            //    if (nums[i] != nums[i - 1])
            //    {
            //        nums[k] = nums[i];
            //        k++;
            //    }

            //}

            //return k;

            //---------------------2--------------
            int[] unique = nums.Distinct().ToArray();

            Array.Copy(unique, nums, unique.Length);

            return unique.Length;
        }
    }
}
