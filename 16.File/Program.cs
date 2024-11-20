using System;
using System.IO;

namespace _16.File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DriveInfo drive = new DriveInfo("C:/"); // get infor drive
            //Console.WriteLine($"Drive: {drive.Name}");
            //Console.WriteLine($"Drive Type {drive.DriveType}");
            //Console.WriteLine($"Label: {drive.VolumeLabel}");
            //Console.WriteLine($"Format: {drive.DriveFormat}");
            //Console.WriteLine($"Size: {drive.TotalSize}");
            //Console.WriteLine($"Free: {drive.TotalFreeSpace}");

            string path = "C:\\Users\\BangChiu\\C#_Basic\\Core_To_Pro\\16.File\\obj";
            //Directory.CreateDirectory(path);
            //Directory.Delete(path);
            //if(Directory.Exists(path))
            //{
            //    Console.WriteLine($"{path} - ton tai");
            //}
            //else Console.WriteLine($"{path} - khong ton tai");
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
