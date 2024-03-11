using System.Runtime.InteropServices;

internal class Program
{
    using (Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex"))
{
    if (!mutex.WaitOne(TimeSpan.Zero, true))
    {
        Console.WriteLine("Close Roblox!");
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
