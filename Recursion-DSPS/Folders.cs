using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Recursion_DSPS
{
    class Folders
    {
        public string Path { get; set; }
        public int Count { get; set; }

        public Folders(string path)
        {
            Path = path;
        }

        public string Algorithm1()
        {
            //this is actually a queue ;)
            List<string> folders = new List<string>();
            folders.AddRange(Directory.GetDirectories(Path));

            while (folders.Count > 0)
            {
                Count++;
                string folder = folders[0];
                if (Directory.GetFiles(folder).Length == 1) return Directory.GetFiles(folder)[0];
                folders.AddRange(Directory.GetDirectories(folder));
                folders.RemoveAt(0);
            }
            return "";
        }

        public string Algorithm2(string path)
        {
            Count++;
            foreach (string element in Directory.GetFileSystemEntries(path))
            {
                if (Directory.Exists(element))
                {
                    string result = Algorithm2(element);
                    if (result != null) return result;
                }
                else return element;
            }
            return null;
        }
    }
}
