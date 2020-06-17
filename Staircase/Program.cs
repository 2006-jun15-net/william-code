using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of stairs to print.");
            // Init input
            int stairCount = 3;
            // Part 2
            try
            {
                stairCount = int.Parse(Console.ReadLine());
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }

            // Check limits
            if (stairCount < 0 || stairCount > 1999999999)
            {
                Console.WriteLine("Invalid number of stairs entered.\n" +
                    "Please enter between [0 - 2000000000) many stairs.");
                return;
            }

            // Stair loop
            for(int stair=stairCount; stair > 0; stair--)
            {
                // Pixel loop
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
            // Easter egg
            if (stairCount >= 50)
            {
                Console.WriteLine("Po: \"Ah. My old enemy: Stairs.\" -Kung Fu Panda" );
            }
            
        }
    }
}
