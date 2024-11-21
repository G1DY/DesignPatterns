using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Strategy.BadSln
{
    public class VideoStorage
    {
        private Compressors _compressors;
        private Overlays _overlays;

        public VideoStorage(Compressors compressors, Overlays overlays)
        {
            _compressors = compressors;
            _overlays = overlays;
        }

        public void SetCompressors(Compressors compressors)
        {
            _compressors = compressors;
        }

        public void setOverlays(Overlays overlays)
        {
            _overlays = overlays;
        }
        public void Store(string fileName)
        {
            // compression logic
            if (_compressors == Compressors.MP4)
            {
                System.Console.WriteLine("Compressing using MP4");
            }
            else if (_compressors == Compressors.MOV)
            {
                System.Console.WriteLine("Compressing using MOV");
            }
            else if(_compressors == Compressors.WEBM)
            {
                System.Console.WriteLine("Compressing using WEBM");
            }
            // overlays logic
            if (_overlays == Overlays.BlackAndWhite)
            {
                System.Console.WriteLine("Applying BlackandWhite overlay");
            }
            else if(_overlays == Overlays.Blur)
            {
                System.Console.WriteLine("Applying Blur overlay");
            }
            else if( _overlays == Overlays.None)
            {
                System.Console.WriteLine("Applying none");
            }
            System.Console.WriteLine("Storing video to " + fileName);
        }
    }
}