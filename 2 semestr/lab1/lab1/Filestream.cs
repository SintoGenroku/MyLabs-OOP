using System.IO;

namespace lab1
{
    internal class Filestream
    {
        private string v;
        private FileMode fileMode;

        public Filestream(string v, FileMode fileMode)
        {
            this.v = v;
            this.fileMode = fileMode;
        }
    }
}