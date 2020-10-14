using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Recursion_IMS
{
    class Folders
    {
        public string Path { get ; set; }
        public int Count { get; set; }

        public Folders(string path)
        {
            Path = path;
        }

        public string Tom()
        {
            string[] filepath = Directory.GetFiles(Path, "*.txt", SearchOption.AllDirectories);
            return filepath[0];
        }

        public string Stef()
        {
            List<string> directories = Directory.GetDirectories(Path).ToList();
            while (directories.Count > 0)
            {
                Count++;
                string path = directories.ElementAt(0);
                if (Directory.GetFiles(path).Length > 0) return Directory.GetFiles(path)[0];
                else if (Directory.GetDirectories(path) != null)
                {
                    directories.AddRange(Directory.GetDirectories(path));
                }
                directories.RemoveAt(0);
            }
            return "niet gevonden?";
        }

        public string Kirsten(string path)
        {
            Count++;
            foreach (string element in Directory.GetFileSystemEntries(path))
            {
                if (Directory.Exists(element))
                {
                    string result = Kirsten(element);
                    if (result != null) return result;
                }
                else return element;
            }
            return null;
        }
    }
}
