using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Numerics;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_Task27
{
    internal class Program
    {
        //Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the elements may be changed.Then return the number of elements in nums which are not equal to val.

        //Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

        //Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.
        //Return k.
        static void Main(string[] args)
        {
            
        }


        public int RemoveElement(int[] nums, int val)
        {
            //-----------------1---------------------
            //base case
            //if (nums is null) return 0;

            //int k = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] != val)
            //    {
            //        nums[k++] = nums[i];
            //    }
            //}

            //return k;

            //-------------------2--------------
            int n = nums.Length;
            int i = 0;

            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[--n];
                }
                else
                {
                    i++;
                }
            }

            return n;
        }
    }
}
