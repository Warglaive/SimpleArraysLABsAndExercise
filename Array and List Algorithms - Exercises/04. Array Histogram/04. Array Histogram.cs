using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    public class Program
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            var words = new List<string>(); //Add words here.
            var counts = new List<int>(); // List for occurances

            for (int i = 0; i < arr.Length; i++)//Iterate over the input
            {
                if (!words.Contains(arr[i]))
                {
                    words.Add(arr[i]);
                    counts.Add(1);
                }
                else
                {
                    for (int k = 0; k < words.Count; k++)
                    {
                        if (arr[i] == words[k])
                        {
                            counts[k]++;
                        }
                    }
                }

            }
            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 0; i < counts.Count - 1; i++)
                {
                    if (counts[i] < counts[i + 1])
                    {
                        int temp = counts[i];
                        counts[i] = counts[i + 1];
                        counts[i + 1] = temp;

                        string tempStr = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempStr;
                        unsorted = true;
                    }

                }
            }
            for (int i = 0; i < words.Count; i++)
            {//percent = oneWordCount * 100 / totalWordsCount;
                double percentage = counts[i] * 100.00 / arr.Length;
                Console.WriteLine($"{words[i]} -> {counts[i]} times ({percentage:F2}%)");
            }
        }
    }
}
