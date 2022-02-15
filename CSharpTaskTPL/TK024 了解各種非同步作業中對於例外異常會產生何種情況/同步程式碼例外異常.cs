using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TK024_了解各種非同步作業中對於例外異常會產生何種情況
{
    public class 同步程式碼例外異常
    {
        public static void Run()
        {
            Console.WriteLine("程式開始執行");
            // 當在執行緒內發生了例外異常，應用程式將會結束執行
            throw new InvalidProgramException($"發生了例外異常");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
