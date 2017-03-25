using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array_Using_Bubble_Sort
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++) 
                {
                    var currentNumber = numbers[i];
                    var nextElement = numbers[i + 1];
                    if (currentNumber > nextElement)
                    {
                        swapped = true;
                        numbers[i+1] = currentNumber;
                        numbers[i] = nextElement;
                    }
                }
            } while (swapped);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
