using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Extension_Task4
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int>
            {
                10, 20, 30, 40
            };

            var secondNumber = numbers.SecondOrDefault();

            Console.WriteLine(secondNumber);


            List<string> names = new List<string>
            {
                "Oleh", "Anna"
            };

            var secondName = names.SecondOrDefault();

            Console.WriteLine(secondName);
        }
    }

    public static class IEnumerableExtnsion
    {
        public static T SecondOrDefault<T>(this IEnumerable<T> items)
        {
            //---------------------1--------------------
            //int index = 0;

            //foreach (T item in items)
            //{
            //    if (index == 1)
            //    {
            //        return item;
            //    }

            //    index++;
            //}

            //return default(T);

            //----------------------2---------------
            //return items.ElementAtOrDefault(1);

            //-----------------------3--------------
            //return items.Skip(1).FirstOrDefault();
        }

    }
}
