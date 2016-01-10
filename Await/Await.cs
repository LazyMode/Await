using System;
using System.Threading.Tasks;

#if NET45 || NativeAwait || !(NET40 || LegacyAwait || CompatibleAwait)
using System.Runtime.CompilerServices;
using TaskEx = System.Threading.Tasks.Task;
#else
using Microsoft.Runtime.CompilerServices;
using TaskEx = System.Threading.Tasks.TaskEx;
#endif

static partial class Await
{
    public static TaskAwaiter GetAwaiter(this int ms)
        => TaskEx.Delay(ms).GetAwaiter();
    public static TaskAwaiter GetAwaiter(this TimeSpan ts)
        => TaskEx.Delay(ts).GetAwaiter();
}
