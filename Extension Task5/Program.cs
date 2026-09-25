namespace Extension_Task5
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            int result = numbers.CountWhere(x => x > 5);

            Console.WriteLine(result);
        }
    }

    public static class IEnumerableExtension
    {
        public static int CountWhere<T>(this IEnumerable<T> items, Func<T, bool> continion)
        {
            //----------------1--------------
            //int result = 0;

            //foreach (var item in items)
            //{
            //    if (continion(item))
            //    {
            //        result++;
            //    }
            //}

            //return result;

            //----------------2--------------
            return items.Count(continion);
        }
    }
}
