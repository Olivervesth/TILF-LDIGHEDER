using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace RNG
{
    class Program
    {
        static void Main(string[] args)
        {
            RNG();
            Console.ReadKey();
            RAN();
            Console.ReadKey();
        }

        public static void RNG()
        {
            int value = 0;
            int i = 0;
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                Stopwatch stopWatch = new Stopwatch();
                byte[] data = new byte[5];
                stopWatch.Start();
                for (i = 0; i < 1000000; i++)
                {
                    rng.GetBytes(data);
                    value = BitConverter.ToInt32(data, 0);
                    Console.WriteLine(value);
                }
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime);
            }
        }
        public static void RAN()
        {
            Random ran = new Random();
            byte[] data = new byte[5];
            int value = 0;
            int i = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (i = 0; i < 1000000; i++)
            {
                ran.NextBytes(data);
                value = BitConverter.ToInt32(data, 0);
                Console.WriteLine(value);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
