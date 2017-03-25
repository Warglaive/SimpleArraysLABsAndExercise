using System;
using System.Linq;
namespace _03.Smallest_Element_in_Array
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
