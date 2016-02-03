using System;
using System.Threading;

#if TaskEx
using Microsoft.Runtime.CompilerServices;
using static System.Threading.Tasks.TaskEx;
#else
using System.Runtime.CompilerServices;
using static System.Threading.Tasks.Task;
#endif

static partial class Await
{
    public static TaskAwaiter<bool> GetAwaiter(this WaitHandle handle)
        => Run((Func<bool>)handle.WaitOne).GetAwaiter();
}
