using System;
using System.Linq;
namespace _04.Rotate_Array_of_Strings
{
    public class Program
    {
        public static void Main()
        {
            string[] words =
                Console.ReadLine()
                .Split(' ');
            var result = new string[words.Length];
            result[0] = words[words.Length - 1];
            for (int i = 0; i < words.Length - 1; i++) 
            {
                result[i + 1] = words[i];
            }
            var resultAsString = string.Join(" ", result);
            Console.WriteLine(resultAsString); 
        }
    }
}
