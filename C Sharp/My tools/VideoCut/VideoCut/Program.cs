using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace VideoCut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a video cutter made by zdfffg");
            Console.WriteLine();
            readSrcPath: Console.WriteLine("Please input the source video full path: ");
            string src = Console.ReadLine();
            if (!System.IO.File.Exists(src))
            {
                Console.WriteLine("Error: Can not find such a file.");
                goto readSrcPath;
            }

            readDstPath: Console.WriteLine("Please input the director you want to generate the video: ");
            string dst = Console.ReadLine();
            if (!System.IO.Directory.Exists(dst))
            {
                Console.WriteLine("Error: Can not find such a directory.");
                goto readDstPath;
            }
            int i = 1;
            while (System.IO.File.Exists(System.IO.Path.Combine(dst, "output" + i + ".mp4")))
            {
                ++i;
            }
            dst = System.IO.Path.Combine(dst, "output" + i + ".mp4");

            Console.WriteLine("Please input the start time here(00:00:00): ");
            string start = Console.ReadLine();

            Console.WriteLine("Please input the duration here(00:00:00): ");
            string duration = Console.ReadLine();

            Console.WriteLine("Starting?(y/n): ");
            if (Console.ReadLine() == "y")
            {
                // ffmpeg -i D:\input.mp4 -ss 00:02:47 -t 00:01:43 -preset ultrafast -crf 23 -ac 2 D:\output.mp4
                Process compiler = new Process();
                compiler.StartInfo.FileName = System.IO.Path.Combine(System.Environment.CurrentDirectory, "ffmpeg.exe");
                compiler.StartInfo.Arguments = " -i " + src + " -ss " + start + " -t " + duration + " -preset ultrafast -crf 23 -ac 2 " + dst;
                compiler.StartInfo.UseShellExecute = false;
                compiler.StartInfo.RedirectStandardOutput = false;
                compiler.StartInfo.CreateNoWindow = false;
                compiler.Start();
            }

            Console.WriteLine("Generate to " + dst + ". Please press any key to exit.");
            Console.ReadKey();
        }
    }
}
