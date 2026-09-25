using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Extension_Task3
{
    internal class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int>
            {
                3, 7, 10, 15, 20, 2, 8
            };

            // TODO: Implement extension method
            var result = numbers.GreaterThan(2);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }

    public static class IEnumerableExtension
    {
        public static IEnumerable<int> GreaterThan(this IEnumerable<int> numbers, int paramtr)
        {
            //------------------1---------------
            //foreach(int number in numbers)
            //{
            //    if(number > paramtr)
            //    {
            //        yield return number;
            //    }
            //}

            //----------------------2----------------

            //List<int> result = new List<int>();

            //foreach (int number in numbers)
            //{
            //    if (number > paramtr)
            //    {
            //        result.Add(number);
            //    }
            //}

            //return result;

            //----------------------3----------------
            return numbers.Where(number => number > paramtr);
        }
    }
}
