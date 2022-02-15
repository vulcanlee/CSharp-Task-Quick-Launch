using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TK024_了解各種非同步作業中對於例外異常會產生何種情況
{
    public class 工作Wait例外異常
    {
        public static void Run()
        {
            var fooTask = Task.Run(async () =>
            {
                await Task.Delay(500);
                throw new InvalidProgramException($"發生了例外異常");
            });

            fooTask.Wait();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
