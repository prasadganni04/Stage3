using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitUsage1AndParameterizedOptionalParameters
{
    class AsyncAwaitUsage1
    {
        static void Main(string[] args)
        {
            string result = Method1().Result;
            Console.WriteLine(result);
            Console.ReadLine();

        }
        public static async Task<string> Method1()
        {
            return await Method2();
        }

        public static async Task<string> Method2()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Async and Await Usage 1.";
            });
        }
    }
}
