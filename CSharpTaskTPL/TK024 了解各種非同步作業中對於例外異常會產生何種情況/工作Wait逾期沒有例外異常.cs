﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TK024_了解各種非同步作業中對於例外異常會產生何種情況
{
    public class 工作Wait逾期沒有例外異常
    {
        public static void Run()
        {
            var fooTask = Task.Run(async () =>
            {
                await Task.Delay(1500);
            });

            var result = fooTask.Wait(1000);

            Console.WriteLine($"此次執行的逾期狀態為 {!result}");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
