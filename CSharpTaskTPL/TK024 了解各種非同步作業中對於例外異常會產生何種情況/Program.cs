using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TK024_了解各種非同步作業中對於例外異常會產生何種情況
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"1. await工作例外異常");
            Console.WriteLine($"2. await工作取消例外異常");
            Console.WriteLine($"3. 工作例外異常");
            Console.WriteLine($"4. 工作取消例外異常");
            Console.WriteLine($"5. 工作尚未啟動就發生例外異常");
            Console.WriteLine($"6. 同步程式碼例外異常");
            Console.WriteLine($"7. 執行緒的例外異常");
            Console.WriteLine($"8. 工作 WaitAll 例外異常");
            Console.WriteLine($"9. 工作 WaitAny 例外異常");
            Console.WriteLine($"A. 工作 Wait 例外異常");
            Console.WriteLine($"B. 工作 Wait 取消例外異常");
            Console.WriteLine($"C. 工作 Wait 逾期沒有例外異常");
            Console.WriteLine($"D. 工作 WhenAny 例外異常");
            Console.WriteLine($"E. 工作 WhentAll 例外異常");
            Console.WriteLine($" ");
            Console.WriteLine($"請輸入要執行的按鍵{Environment.NewLine}{Environment.NewLine}");
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1) await await工作例外異常.RunAsync();
            if (key.Key == ConsoleKey.D2) await await工作取消例外異常.RunAsync();
            if (key.Key == ConsoleKey.D3) 工作例外異常.Run();
            if (key.Key == ConsoleKey.D4) 工作取消例外異常.Run();
            if (key.Key == ConsoleKey.D5) 工作尚未啟動就發生例外異常.Run();
            if (key.Key == ConsoleKey.D6) 同步程式碼例外異常.Run();
            if (key.Key == ConsoleKey.D7) 執行緒的例外異常.Run();
            if (key.Key == ConsoleKey.D8) 工作WaitAll例外異常.Run();
            if (key.Key == ConsoleKey.D9) 工作WaitAny例外異常.Run();
            if (key.Key == ConsoleKey.A) 工作Wait例外異常.Run();
            if (key.Key == ConsoleKey.B) 工作Wait取消例外異常.Run();
            if (key.Key == ConsoleKey.C) 工作Wait逾期沒有例外異常.Run();
            if (key.Key == ConsoleKey.D) await 工作WhenAny例外異常.RunAsync();
            if (key.Key == ConsoleKey.E) await 工作WhentAll例外異常.RunAsync();
        }
    }
}
