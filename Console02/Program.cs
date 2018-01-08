using System;

namespace Console02
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoFilter pFilter = new PhotoFilter();

            // first approach
            PhotoProcess.ApplyFilter pProcess = pFilter.ApplyBrightness;
            pProcess += pFilter.ApplyColor;

            var photoProcess = new PhotoProcess(); 
            photoProcess.Process("C:/",pProcess);

            // second approach
            Action<Photo> photoProcessMethodDelegat;
            photoProcessMethodDelegat = pFilter.ApplyBrightness;
            photoProcessMethodDelegat += pFilter.ApplyColor;

            photoProcess.ProcessWithAction("C:/",photoProcessMethodDelegat);
        }
    }
}
