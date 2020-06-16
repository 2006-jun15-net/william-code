using System;

namespace CollatzSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of Collatz numbers to print.");

            long number = -404;
            try
            {
                number = long.Parse(Console.ReadLine());
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

            switch (number)
            {
                case 0: Console.WriteLine("0\n1");
                    break;
                case 1: Console.WriteLine("1");
                    break;
            }
            if (number < 0)
            {
                Console.WriteLine("Input must me an integer number greater than -1");
                return;
            }

            while (number > 1)
            {
                try
                {
                    if (number%2 == 0)
                    {
                        number /= 2;
                    } else
                    {
                        number = number*3 +1;
                    }
                } catch
                {
                    Console.WriteLine("The number you entered was too large.");
                    return;
                }
                
                Console.WriteLine(number);
            }

        }
    }
}
