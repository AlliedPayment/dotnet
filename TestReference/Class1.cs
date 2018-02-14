using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Profiling;

namespace TestReference
{
    public static class Class1
    {
        public static void Main()
        {
            
            var profiler = MiniProfiler.StartNew();
            using (profiler.Step("woot"))
            {
                System.Threading.Thread.Sleep(100);
            }

            profiler.Stop();
            var str = profiler.RenderPlainText();
        }
    }
}
