using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
             var watcher = new FileSystemWatcher(@"X:\Programmierung\c_sharp\FileWatcher\FileWatcher\test");

            watcher.NotifyFilter = NotifyFilters.LastAccess;

            watcher.Changed += OnChanged;
            watcher.Filter = "testfile.txt";
            

            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        private static void OnChanged(Object sender, FileSystemEventArgs e)
        {
            /*
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            */
            Console.WriteLine($"Changed: {e.FullPath}");
        }
    }
}
