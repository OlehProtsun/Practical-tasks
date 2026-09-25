namespace Extension_Task8
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new()
            {
                1, 3, 5, 8, 9
            };

            bool result = numbers.AnyWhere(x => x % 2 == 0);

            Console.WriteLine(result);
        }
    }

    public static class IEnumerableExtension
    {
        public static bool AnyWhere<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            //-------------1------------
            //foreach (T item in items)
            //{
            //   if (predicate(item)) return true;
            //}

            //return false;

            //---------2----------
            return items.Any(predicate);
        }
    }
}
