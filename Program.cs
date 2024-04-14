using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobloxMultipleAccounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex"))
            {
                if (!mutex.WaitOne(TimeSpan.Zero, true))
                {
                    Console.WriteLine("Close Roblox and restart app.");
                    Thread.Sleep(2000);
                    return;
                }

                Console.WriteLine("Nice cocks!");

                while (true)
                {
                    Thread.Sleep(int.MaxValue);
                }
            }
        }
    }
}
