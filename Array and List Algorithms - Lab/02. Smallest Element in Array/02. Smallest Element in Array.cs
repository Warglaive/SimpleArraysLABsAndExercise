using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var max = numbers.First();
            foreach (var num in numbers)
            {
                if (num < max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
