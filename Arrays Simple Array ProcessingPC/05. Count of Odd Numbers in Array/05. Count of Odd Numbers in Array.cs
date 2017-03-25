using System;
using System.Linq;
namespace _05.Count_of_Odd_Numbers_in_Array
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int oddcount = 0
                ;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddcount++;
                }
                else if (numbers[i]%2 == -1)
                {
                    oddcount+= 1;
                }
            }
            Console.WriteLine(oddcount);
        }
    }
}
