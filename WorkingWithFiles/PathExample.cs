using System;
using System.IO;

namespace WorkingWithFiles
{
    public class PathExample
    {
        public PathExample()
        {
            var directory = "/Users/itabarino/Downloads/";
            var path = $"{directory}/test123.txt";

            Console.WriteLine(Path.GetExtension(path));

            Console.WriteLine(Path.GetFileName(path));

            Console.WriteLine(Path.GetFileNameWithoutExtension(path));

            Console.WriteLine(Path.GetDirectoryName(path));
        }
    }
}
