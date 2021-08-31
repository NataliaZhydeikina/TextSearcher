using System.IO;

namespace TextSearcher.FileSearcher.EventArgs
{
    public class FoundInfoEventArgs
    {
        public FoundInfoEventArgs(FileSystemInfo info, int count)
        {
            Info = info;
            Count = count;
        }

        public FileSystemInfo Info { get; }
        public int Count { get; }

    }
}
