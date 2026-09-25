using System.Runtime.CompilerServices;

namespace Extension_Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new()
            {
                2, 4, 6, 8
            };

            bool result = numbers.AllWhere(x => x % 2 == 0);

            Console.WriteLine(result);
        }
    }

    public static class IEnumerableExtension
    {
        public static bool AllWhere<T>(this IEnumerable<T> items, Func<T, bool> condition)
        {
            //-------------1-----------
            //foreach(T item in items)
            //{
            //    if (!condition(item))
            //    {
            //        return false;                    
            //    }
            //}

            //return true;

            //------2-----------
            return items.All(condition);
        }
    }
}
