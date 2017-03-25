using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Insertion_Sort_Using_List
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var totalNumbers = int.Parse(Console.ReadLine());
            numbers.Sort();
            numbers.Reverse();

            var result = numbers.Take(totalNumbers);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
