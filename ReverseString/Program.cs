using System;

namespace reverseString
{
    class Program
    {
        static string ReverseString(string str)
        {
            string reversedStr = "";
            char[] charArr = str.ToCharArray();
            for (int i=charArr.Length-1; i>=0; i--)
                reversedStr += charArr[i];

            return reversedStr;
        }
        static void Main(string [] args)
        {
            Console.WriteLine(ReverseString(args.Length != 0 ? args[0] : "No String Given"));
        }
    }



    // namespace Derp
    // {
    //    class Reverse
    //    {

    //    }
    // }
}