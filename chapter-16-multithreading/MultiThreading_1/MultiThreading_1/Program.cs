using System.Threading;

namespace MultiThreading_1
{
    public class Program
    {
        public static void Main()
        {
            Counter counter_0 = new Counter(5, 4);

            Thread MyThread_0 = new Thread(new ThreadStart(counter_0.Count));
            MyThread_0.Start();
        }
    }
}