using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FileSystem
{
    class RecursiveFileSearch
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        static long fileNums = 0;

        static void Main()
        {
            // Start with drives if you have to search the entire computer.
            string[] drives = System.Environment.GetLogicalDrives();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (string dr in drives)
            {
                System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

                // Here we skip the drive if it is not ready to be read. This
                // is not necessarily the appropriate action in all scenarios.
                if (!di.IsReady)
                {
                    Console.WriteLine("The drive {0} could not be read", di.Name);
                    continue;
                }
                System.IO.DirectoryInfo rootDir = di.RootDirectory;
                WalkDirectoryTree(rootDir);
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("遍历的文件总数：" + fileNums);
            Console.WriteLine("RunTime：" + elapsedTime);

            // Write out all the files that could not be processed.
            //Console.WriteLine("Files with restricted access:");
            //foreach (string s in log)
            //{
            //    Console.WriteLine(s);
            //}
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            // 只要files中有一个没有访问权限，就会抛出异常
            catch (UnauthorizedAccessException e)
            {
                // This code just writes out the message and continues to recurse.
                // You may decide to do something different here. For example, 
                // 你可以提高权限并再次访问他们
                log.Add(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    // In this example, we only access the existing FileInfo object. If we
                    // want to open, delete or modify the file, then
                    // a try-catch block is required here to handle the case
                    // where the file has been deleted since the call to TraverseTree().
                    Console.WriteLine(fi.FullName);

                    ++fileNums;
                }
            }

            // 这个地方很奇怪，原本是放在上面的if语句中的。
            // 意思是如果该路径下有文件，就查找有没有文件夹？所以我放出来了，并加上异常捕捉。
            // Now find all the subdirectories under this directory.
            try
            {
                subDirs = root.GetDirectories();
            }
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (subDirs != null)
            {
                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTree(dirInfo);
                }
            }
        }
    }
}
