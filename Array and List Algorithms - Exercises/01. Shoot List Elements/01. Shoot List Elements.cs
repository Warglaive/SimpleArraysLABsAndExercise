using System;
using System.Collections.Generic;
namespace _01.Shoot_List_Elements
{
    public class Program
    {
        public static void Main()
        {
            var result = new List<double>();
            var command = Console.ReadLine();
            double averageNumber = 0;
            do
            {
                if (command == "stop") 
                {
                    break;
                }
                if (command == "bang")
                {
                    continue;
                }
                var number = int.Parse(command);
                result.Insert(0, number);
                command = Console.ReadLine();
            } while (command != "stop" && command != "bang");
            while (command == "bang") 
            {
                averageNumber = 0;
                for (int i = 0; i <= result.Count-1; i++)
                {
                    averageNumber += result[i];
                }
                averageNumber = averageNumber / result.Count;
                for (int i = 0; i <= result.Count-1; i++)
                {
                    if (result[i] <= averageNumber)
                    {
                        Console.WriteLine($"shot {result[i]}");
                        result.Remove(result[i]);
                        for (int row = 0; row < result.Count; row++)
                        {
                            result[row]--;
                        }
                        break;
                    }
                }
                command = Console.ReadLine();
                if (command=="bang" && result.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {averageNumber}");
                    break;
                }
                else if (command == "stop")
                {
                    if (result.Count > 0)
                    {
                        foreach (var left in result)
                        {
                            Console.WriteLine($"survivors: {string.Join(" ", result)}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"you shot them all. last one was {averageNumber}");
                    }
                }
            }
        }
    }
}