using System.Collections.Generic;
using System.IO;

namespace lab13
{
     class BASFileManager
    {
        private DirectoryInfo dir;
        private List <DirectoryInfo> list;
        public BASFileManager(string path) 
        {
            dir = new DirectoryInfo(path);
        }
        public void FileManager() 
        {
            dir.GetDirectories();
        }
    }
}
