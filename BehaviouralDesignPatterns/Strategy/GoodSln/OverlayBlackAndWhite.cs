using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Strategy.GoodSln
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying BlackandWhite overlay");
        }
    }
}