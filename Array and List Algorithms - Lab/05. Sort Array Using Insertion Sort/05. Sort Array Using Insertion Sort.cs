﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Array_Using_Insertion_Sort
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var index = Console.ReadLine();
            for (int i = 0; i < numbers.Length - 1; i++) 
            {
                var j = i + 1;
                while (j > 0) 
                {
                    if (numbers[j] < numbers[j - 1]) 
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }
                    j--;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
