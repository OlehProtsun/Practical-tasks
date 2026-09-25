namespace Extension_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new()
            {
                1, 2, 3, 4, 5
            };

            var result = numbers.Transform(x => x * 10);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }

    public static class IEnumerableExtension
    {
        public static IEnumerable<TResult> Transform<T, TResult>(this IEnumerable<T> items, Func<T, TResult> transformer)
        {
            //------------1-----------
            //foreach (T item in items)
            //{
            //    yield return transformer(item);
            //}

            //----------------2----------
            return items.Select(transformer);
        }
    }
}
