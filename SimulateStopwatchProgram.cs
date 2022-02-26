using System;
using System.Diagnostics;
using System.Threading;

namespace logical_programming
{
    public class SimulatingStopWatch
    {
        public static void stopwatch()
        {

            Stopwatch stopwatch = new Stopwatch();


            stopwatch.Start();


            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }


            stopwatch.Stop();


            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
