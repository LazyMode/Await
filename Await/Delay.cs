using System;

#if TaskEx
using Microsoft.Runtime.CompilerServices;
using static System.Threading.Tasks.TaskEx;
#else
using System.Runtime.CompilerServices;
using static System.Threading.Tasks.Task;
#endif

static partial class Await
{
    public static TaskAwaiter GetAwaiter(this int ms)
        => Delay(ms).GetAwaiter();
    public static TaskAwaiter GetAwaiter(this TimeSpan ts)
        => Delay(ts).GetAwaiter();
}
