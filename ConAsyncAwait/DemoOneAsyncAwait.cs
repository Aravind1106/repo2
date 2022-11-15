using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAsyncAwait
{
    internal class DemoOneAsyncAwait
    {
        static void Main()
        {
            Method1();
            Method2();
            Console.ReadLine();

        }

        private static async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i + "of Method2");
                    Task.Delay(300).Wait();
                }
            });
        }
        private static void Method1()
        {
            for (int i = 0; i < 25; i ++)
            {
                Console.WriteLine(i+"of Method1");
                Task.Delay(300).Wait();
            }
        }
    }
}
