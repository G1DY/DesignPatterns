using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Strategy.GoodSln
{
    public class VideoStorage
    {
        private IOverlay _overlay;
        private ICompressor _compressor;

        public VideoStorage(IOverlay overlay, ICompressor compressor)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressors(ICompressor compressor)
        {
            _compressor = compressor;
        }
         public void SetOverlays(IOverlay overlay)
         {
            _overlay = overlay;
         }

         public void Store(string fileName)
         {
            _compressor.Compress();
            _overlay.Apply();

            System.Console.WriteLine("Storing video to " + fileName);
         }
         
    }
}