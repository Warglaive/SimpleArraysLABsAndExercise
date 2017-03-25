using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace _01.Array_Contains_Element
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var index = int.Parse(Console.ReadLine());
            var result = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == index)
                {
                    result = true;
                    break;
                }
            }
            if (result == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
