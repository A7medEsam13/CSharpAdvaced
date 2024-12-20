﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Recursion
{

    public class App
    {
        
    static public void Run()
        {

        }
    static void PrintDirectoryFileSystemEntries(string path, int level)
    {
        foreach (var fileName in Directory.GetFiles(path))
        {
            Console.WriteLine($"{new string('-', level)} {new FileInfo(fileName).Name}");
        }
        foreach (var dirName in Directory.GetDirectories(path))
        {
            Console.WriteLine($"{new string('-', level)} {new DirectoryInfo(dirName).Name}");
            PrintDirectoryFileSystemEntries(dirName, level + 1);
        }
    }

    static long Size(string path)
    {
        long size = 0;
        foreach (var fileName in Directory.GetFiles(path))
        {
            size += new FileInfo(fileName).Length;
        }
        foreach (var file in Directory.GetDirectories(path))
        {
            size += Size(file);
        }

        return size;
    }
    }
}
