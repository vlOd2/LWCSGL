using System;
using System.Diagnostics;

namespace LWCSGL.Test
{
    public static class TimeUtil
    {
        public static long NanoTime => Stopwatch.GetTimestamp() * 100L;

        public static long MilliTime => DateTimeOffset.Now.ToUnixTimeMilliseconds();
    }
}
