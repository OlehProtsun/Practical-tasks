using System.Collections;

namespace Extension_Task6
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new()
            {
                2, 4, 7, 10, 15
            };

            var result = numbers.FirstWhere(x => x > 5);

            Console.WriteLine(result);
        }
    }

    public static class IEnumerableExtension
    {
        public static T FirstWhere<T>(this IEnumerable<T> items, Func<T, bool> condition)
        {
            //--------------1--------------
            //foreach (T item in items)
            //{
            //    if (condition(item))
            //    {
            //        return item;
            //    }
            //}

            ////throw new InvalidOperationException("Not correct condition");
            //return default(T);

            //--------------2-----------------
            //return items.First(condition);

            //--------------3-----------------
            return items.FirstOrDefault(condition);
        }
    }
}
