using System;

namespace BumperBoats
{
    // If characteristics of performance is important.
    // Might need to switch between functions that sort,
    //  so an interface provides a way to switch between function versions more easily.
    public interface ISortingAlgorithm
    {
        void Sort(int[] array);
    }

    class Program
    {
        public static int[] ConvertToFraction(decimal target)
        {
            decimal top = 1.0M, bottom = 1.0M;
            decimal result = top / bottom;

            const int LIMIT = 10000000;
            int itr = 0;
            while(Math.Abs(result - target) > 0.00000000005M)
            {
                itr++;
                if(result > target)
                {
                    bottom += 1.0M;
                } else
                {
                    top += 1.0M;
                }

                result = top / bottom;

                if(itr > LIMIT) break;
            }

            Console.WriteLine("Target = " + target);
            Console.WriteLine("Estimation = " + result);

            int [] topBottom = {(int)top, (int)bottom};
            return topBottom;
        }

        static void Main(string[] args)
        {
            decimal target = 0.5107843137M;
            // decimal topVal = 1.0M, bottomVal = 1.0M;
            // decimal result = 56.0M / 135.0M; // .4_148_148...
            int [] fractionParts = ConvertToFraction(target);

            

            // result = 138.0M / (decimal)(15*27);
            Console.WriteLine("Fraction = " + fractionParts[0] + "/" + fractionParts[1]);
        }
    }
}
