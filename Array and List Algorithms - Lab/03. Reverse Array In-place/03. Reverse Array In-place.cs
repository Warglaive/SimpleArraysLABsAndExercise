using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length / 2; i++) 
            {
                var leftIndex = i;
                var rightIndex = numbers.Length - 1 - i;

                var temp = numbers[leftIndex];
                numbers[leftIndex] = numbers[rightIndex];
                numbers[rightIndex] = temp;
            }
            Console.WriteLine(string.Join(" " , numbers));
        }
    }
}
