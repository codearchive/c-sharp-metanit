using System;
using System.Threading;

namespace MultiThreading_0
{
    class Program
    {
        static void Main()
        {
            // Create new Thread
            Thread myThread = new Thread(Count);
            myThread.Start(); // Run Thread

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Main Thread:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }

            Console.ReadLine();
        }

        public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Second Thread:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }
    }
}
