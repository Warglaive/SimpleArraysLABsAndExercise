using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = 0;
           // char[] newResult = text(stringSplitOptions)
            var spaceCounter = 0;
            foreach (var word in text)
            {
                if (word== ' ')
                {
                    spaceCounter++;
                    continue;
                }
                result += word;
            }
            result /= text.Length - spaceCounter;
            var resultToChar = Convert.ToChar(result);
            var toUpperCase = char.ToUpper(resultToChar);
            var delimer = toUpperCase.ToString();
            foreach (var x in text)
            {
                Console.Write(delimer);
                Console.Write(x);
            }
            Console.WriteLine();
        }
    }
}
