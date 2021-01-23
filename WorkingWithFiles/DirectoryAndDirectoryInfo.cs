using System;
using System.IO;

namespace WorkingWithFiles
{
    public class DirectoryAndDirectoryInfo
    {
        public DirectoryAndDirectoryInfo()
        {
            // Directory provides static methods and
            // DirectoryInfo provides instance methods
            // Directory is good to use when you don't have to handle with many files
            // DirectoryInfo has a better performance for this type of situation

            var path = "/Users/itabarino/Downloads/";

            Directory.CreateDirectory($"{path}/test");

            var txtFiles = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            foreach (var item in txtFiles)
            {
                Console.WriteLine(item);
            }

            var directories = Directory.GetDirectories(path);
            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }

            if (Directory.Exists($"{path}/test"))
            {
                Directory.Delete($"{path}/test");
            }

            Console.WriteLine("Directory Info");

            var directoryInfo = new DirectoryInfo(path);
            var directoriesInfo = directoryInfo.GetDirectories();
            foreach (var item in directoriesInfo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
