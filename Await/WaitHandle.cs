using System;
using System.Threading;
using System.Threading.Tasks;

#if TaskEx
using Microsoft.Runtime.CompilerServices;
using static System.Threading.Tasks.TaskEx;
#else
using System.Runtime.CompilerServices;
using static System.Threading.Tasks.Task;
#endif

static partial class Await
{
    public static TaskAwaiter GetAwaiter(this WaitHandle handle)
        => Run(handle.WaitOne).GetAwaiter();
}
