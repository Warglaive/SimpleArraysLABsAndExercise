using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(' ').ToArray();
            for (var i = 0; i < text.Length; i++)
            {
                for (int j = i+1; j < text.Length; j++)
                {
                    var result = text[i].CompareTo(text[j]);
                    if (result == 1)
                    {
                        var temp = text[i];
                        text[i] = text[j];
                        text[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
