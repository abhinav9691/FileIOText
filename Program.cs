using System;
using System.IO;

namespace FileIOOperationsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fileExists();
            //ReadAllLines();
            //ReadAllText();

            StreamReaderWriterOps readThroughStreamReader = new StreamReaderWriterOps();
            //readThroughStreamReader.WriteUsingStreamWriter();
            readThroughStreamReader.ReadFromStreamReader();
        }

        public static void fileExists()
        {
            //String path = @"/c/Users/dell/source/repos/FileIOOperationsDemo/FileIOOperationsDemo/Example.txt";
            String path = @"C:\Users\dell\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }

        public static void ReadAllLines()
        {
            String path = @"C:\Users\dell\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";

            String[] lines;

            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.ReadKey();

        }
        public static void ReadAllText()
        {
            String path = @"C:\Users\dell\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";

            String lines;

            lines = File.ReadAllText(path);

            Console.WriteLine(lines);

            Console.ReadKey();

        }


    }
}