using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of stairs to print.");
            // Part 2
            int stairCount = int.Parse(Console.ReadLine());
            
            for(int stair=stairCount; stair > 0; stair--)
            {
                for(int pixel = 0; pixel <= stairCount; pixel++)
                {
                    if (pixel < stair)
                    {
                        Console.Write(" ");
                    } else
                    {
                        Console.Write("#");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
