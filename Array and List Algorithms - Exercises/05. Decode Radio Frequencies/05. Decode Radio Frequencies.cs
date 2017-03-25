using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecodeRadioFreq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                var franquences = new string[2];
                franquences = input[i].Split('.');
                var left = int.Parse(franquences[0]);
                var right = int.Parse(franquences[1]);
                char leftChar = (char)left;
                char rightChar = (char)right;
                if (left != 0) 
                {
                    result.Insert(i, leftChar);
                }
                if (right != 0) 
                {
                    result.Insert(result.Count - i, rightChar);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}