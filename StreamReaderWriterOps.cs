using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperationsDemo
{
    public class StreamReaderWriterOps
    {
        public void WriteUsingStreamWriter()
        {
            String path = @"C:\Users\dell\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello world - .Net is awesome");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }

        public void ReadFromStreamReader()
        {
            String path = @"C:\Users\dell\source\repos\FileIOOperationsDemo\FileIOOperationsDemo\Example.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";

                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey() ;
        }
    }
}
