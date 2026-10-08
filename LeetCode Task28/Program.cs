using Microsoft.VisualBasic;

namespace LeetCode_Task28
{
    internal class Program
    {
        //Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        static void Main(string[] args)
        {
           
        }

        public int StrStr(string haystack, string needle)
        {
            //-------------------1----------------
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j = 0;

                while (j < needle.Length &&
                       haystack[i + j] == needle[j])
                {
                    j++;
                }

                if (j == needle.Length)
                    return i;
            }

            return -1;

            //-----------------------2----------------
            return haystack.IndexOf(needle, StringComparison.Ordinal);
        }
    }
}
