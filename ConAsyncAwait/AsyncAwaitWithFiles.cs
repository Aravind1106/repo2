using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConAsyncAwait
{
    internal class AsyncAwaitWithFiles
    {
        public static async Task<int> ReadFromFile(string file)
        {
            int fileLength = 0;
            Console.WriteLine("start reading the files .......");
            using(StreamReader sr = new StreamReader(file))
            {
                string res =await sr.ReadToEndAsync();
                fileLength=res.Length;
            }
            Console.WriteLine("Reading of file is completed ...");
            return fileLength;

        }
        static void Main()
        {
            Task<int> task=ReadFromFile(@"")
        }
    }
}