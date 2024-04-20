using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWCSGL
{
    public static class TimeUtil
    {
        public static long NanoTime => Stopwatch.GetTimestamp() * 100L;

        public static long MilliTime => DateTimeOffset.Now.ToUnixTimeMilliseconds();
    }
}
