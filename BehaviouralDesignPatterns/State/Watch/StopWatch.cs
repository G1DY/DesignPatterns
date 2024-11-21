using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.State.Watch
{
    public class StopWatch
    {
        private bool IsRunning{ get; set; }

        public void Click()
        {
            if (IsRunning)
            {
                IsRunning = true;
                System.Console.WriteLine("Watch started");
            }
            else
            {
                IsRunning = false;
                System.Console.WriteLine("Watch Stopped");
            }
        }
    }
}