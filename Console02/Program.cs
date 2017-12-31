using System;

namespace Console02
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoFilter pFilter = new PhotoFilter();

            PhotoProcess.ApplyFilter pProcess = pFilter.ApplyBrightness;
            pProcess += pFilter.ApplyColor;

            var photoProcess = new PhotoProcess(); 

            photoProcess.Process("C:/",pProcess);
        }
    }
}
