namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new()
            {
                1, 2, 2, 3, 3, 3, 4, 4
            };

            Dictionary<int, int> result = numbers.CountNumbers();

            foreach(var par in result)
            {
                Console.WriteLine($"{par.Key} -> {par.Value}");
            }

        }
    }

    public static class IEnumerableExtension
    {
        public static Dictionary<T, int> CountNumbers<T>(this IEnumerable<T> items) where T : notnull
        {
            //-------------1--------------------
            Dictionary<T, int> result = new Dictionary<T, int>();

            foreach (T item in items)
            {
                if (!result.ContainsKey(item))
                {
                    result.Add(item, 1);
                }
                else
                {
                    result[item]++;
                }

            }

            return result;

            //---------------2----------------

        }
    }
}
