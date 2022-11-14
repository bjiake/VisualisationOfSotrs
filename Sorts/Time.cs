using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorts {
    internal class Time {
        Stopwatch Timer = new Stopwatch();
        public void TimeStart() {
            Timer.Start();
            Thread.Sleep(1);
        }
        public string TimeEnd() {
            Timer.Stop();
            return Convert.ToString(Timer.ElapsedMilliseconds);
        }
    }
}
