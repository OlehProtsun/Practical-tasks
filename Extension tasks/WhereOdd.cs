using System.Diagnostics.CodeAnalysis;

namespace Extension_tasks
{
    internal class WhereOdd
    {
        public static void Main()
        {
            List<int> numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var oddNumbers = numbers.WhereOdd();

            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }

    }
    public static class IEnumerableExtension
    {
        public static IEnumerable<int> WhereOdd(this IEnumerable<int> numbers)
        {
            //------------------1--------------------

            //List<int> result = new List<int> { };

            //foreach (var number in numbers)
            //{
            //    if(number % 2 != 0)
            //    {
            //        result.Add(number);
            //    }
            //}

            //return result;

            //----------------2--------------------

            //return numbers.Where(n => n % 2 != 0);

            //-----------------3------------------

            //foreach (var number in numbers)
            //{
            //    if (number % 2 != 0)
            //    {
            //        yield return number;
            //    }
            //}
        }
    }
}
