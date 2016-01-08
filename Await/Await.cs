using System;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

#if !Async40
using TaskEx = System.Threading.Tasks.Task;
#endif

public static class Await
{
    public static TaskAwaiter GetAwaiter(this int ms)
        => TaskEx.Delay(ms).GetAwaiter();
    public static TaskAwaiter GetAwaiter(this TimeSpan ts)
        => TaskEx.Delay(ts).GetAwaiter();
}