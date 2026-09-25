using System.Net.Security;

namespace Extension_Task2
{
    public class ToTitleCase
    {
        public static void Main()
        {
            string text = "hello world";

            // TODO: Implement the ToTitleCase extension method
            var result = text.ToTitleCase();

            Console.WriteLine(result);
        }
    }

    public static class StringExtension
    {
        public static string ToTitleCase(this string text)
        {
            //---------------------1----------------
            //string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //string result = string.Empty;

            //foreach (string word in words)
            //{
            //    char[] letters = word.ToCharArray();

            //    letters[0] = char.ToUpper(letters[0]);

            //    string upperWord = new string(letters);

            //    result += upperWord + " ";
            //}

            //return result.TrimEnd();

            //-------------------2--------------------

            return string.Join(" ",
                text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }
    }

}
