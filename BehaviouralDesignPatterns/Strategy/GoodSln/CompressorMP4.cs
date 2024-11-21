using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Strategy.GoodSln
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using MP4");
        }
    }
}