using System;

namespace Console02
{
    class Photo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public static Photo Load(string path)
        {
            return new Photo();
        }
        
        public void Save()
        {
            // do something
        }
    }
}