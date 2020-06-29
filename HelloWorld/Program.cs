using System;

namespace HelloWorld
{
    class TestClass
    {
        private int x, y;

        public TestClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void printXY()
        {
            Console.WriteLine("x = " + this.x + "  y = " + this.y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1,y = 2, z = 3;
            var v = true;
            
            Console.WriteLine(v);

            // short (2-byte). long (8-byte).
            Console.WriteLine("Henlo Worl! xyz = " + x + y + z);

            // No default constructor for TestClass

        }
    }
}
