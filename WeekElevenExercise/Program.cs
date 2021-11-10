using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WeekElevenExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\Sample";
            // string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories); 
            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            // }
            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            //foreach (string file in files)
            //{
            //    //Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtessnsion(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));
            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            //}
            //string newPath = @"E:\Temp\Demos\FileSystem\SubFolderC\SubSubFolderD";
            //Directory.CreateDirectory(newPath);
            //bool directoryExists = Directory.Exists(newPath);
            // if (directoryExists)
            // {
            //     Console.WriteLine("The directory exists");
            // }
            // else
            // {
            //     Console.WriteLine("The directory does not exist");
            //     Directory.CreateDirectory(newPath);
            // }
            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"E:\Temp\Demos\FileSystem\SubFolderA";
            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}", true);
            //}
            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                //    //Console.WriteLine(Path.GetFileName(file));
                //    //Console.WriteLine(Path.GetFileNameWithoutExtessnsion(file));
                //    //Console.WriteLine(Path.GetDirectoryName(file));
                //var info = new FileInfo(file);
                //Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            }
            Console.ReadLine();
        }
    }
}
