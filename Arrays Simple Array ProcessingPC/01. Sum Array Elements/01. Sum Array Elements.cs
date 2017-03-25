using System;
namespace _01.Sum_Array_Elements
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }
            var result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                result += currentNumber;
            }
            Console.WriteLine(result);
        }
    }
}
