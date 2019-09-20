using System;
using System.Threading;

namespace MultiThreading_1
{
    public class Counter
    {
        public int x { get; set; }
        public int y { get; set; }

        public Counter(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Second thread:");
                Console.WriteLine(i * x * y);
                Thread.Sleep(400);
            }
        }
    }
}
