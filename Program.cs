using System.Runtime.InteropServices;

internal class Program
{
    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_HIDE = 0;

    private static void Main(string[] args)
    {
        var handle = GetConsoleWindow();

        if (handle != IntPtr.Zero)
            ShowWindow(handle, SW_HIDE);

        new Mutex(true, "ROBLOX_singletonMutex");
        Thread.Sleep(Timeout.Infinite);
    }
}