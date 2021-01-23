using System;
using System.IO;

namespace WorkingWithFiles
{
    public class FileAndFileInfo
    {
        public FileAndFileInfo()
        {
            // File provides static methods and
            // FileInfo provides instance methods
            // File is good to use when you don't have to handle with many files
            // FileInfo has a better performance for this type of situation

            var path = "/Users/itabarino/Downloads/";
            var filePath = $"{path}/test123.txt";
            var fileCopyPath = $"{path}/test123_copy.txt";

            File.Copy(filePath, fileCopyPath, true);

            if (File.Exists(fileCopyPath))
            {
                Console.WriteLine("File Copy Exists");
                File.Delete(fileCopyPath);
            }

            var content = File.ReadAllText(filePath);
            Console.WriteLine(content);


            var fileInfo = new FileInfo(filePath);
            fileInfo.CopyTo(fileCopyPath);

            var fileCopyInfo = new FileInfo(fileCopyPath);

            if (fileCopyInfo.Exists)
            {
                Console.WriteLine("File Copy Exists");
                fileCopyInfo.Delete();
            }
        }
    }
}
