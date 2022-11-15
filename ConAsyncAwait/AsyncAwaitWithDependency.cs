using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAsyncAwait
{
    internal class AsyncAwaitWithDependency
    {
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method1 : " + i);
                    count++;
                }
            });
            return count;
        }
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method2 : " + i);
            }
        }
        public static void Method3(int count)
        {
            Console.WriteLine($"Total Count is : {count}");
        }
        public static async void CallingMethod()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
        }
        static void Main()
        {
            CallingMethod();
            Console.ReadLine();
        }
    }
}
