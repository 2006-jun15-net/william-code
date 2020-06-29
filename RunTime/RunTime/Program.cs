using System;
using System.Collections.Generic;
using System.Linq;

namespace RunTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer: " + RunTime( new List<int>() { 3, 8, 4, 2, 6} ));

        }

        static int RunTime(List<int> times)
        {
            times.Sort();

            Console.WriteLine(string.Join(", ", times));

            List<int> totalTimes = new List<int>();

            int total = 0;
            foreach(int time in times)
            {
                totalTimes.Add(time + total);
                total += time;
            }
            total = 0;
            foreach(int time in totalTimes)
            {
                total += time;
            }

            Console.WriteLine(total + "/" + times.Count);

            return total / times.Count;
        }
    }
}
