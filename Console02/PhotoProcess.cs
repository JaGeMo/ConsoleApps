using System;

namespace Console02
{
    class PhotoProcess
    {
        public delegate void ApplyFilter(Photo photo);

        public void Process(string path, ApplyFilter filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }

        public void ProcessWithAction(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }
}