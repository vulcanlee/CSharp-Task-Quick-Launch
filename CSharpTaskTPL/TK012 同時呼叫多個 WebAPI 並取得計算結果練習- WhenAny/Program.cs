using System.Threading.Tasks;

namespace TK012_同時呼叫多個_WebAPI_並取得計算結果練習__WhenAny
{
    class Program
    {
        // 呼叫 Web API 的網址清單
        static List<string> 工作IDs = new List<string>()
        {
            "https://lobworkshop.azurewebsites.net/api/RemoteSource/Add/22/33/7",
            "https://lobworkshop.azurewebsites.net/api/RemoteSource/Add/8/109/2",
            "https://lobworkshop.azurewebsites.net/api/RemoteSource/Add/231/55/3"
        };
        static async Task Main(string[] args)
        {
            // 建立一個非同步工作清單
            Task<int>[] allTasks = (from 工作ID in 工作IDs select 非同步工作委派方法Async(工作ID)).ToArray();
            Console.WriteLine($"開始執行三個非同步工作:{DateTime.Now}");

            // 呼叫 Web API 的累計計算總合
            int sum = 0;
            try
            {
                // 檢查是否還有未完成的工作
                while (allTasks.Length > 0)
                {
                    // 等候任何一個工作完成
                    var task = Task.WhenAny(allTasks).Result;

                    #region 列印出此工作的執行結果訊
                    Console.WriteLine($"    全部工作數量 {allTasks.Length} ， 子工作執行結果 : {task.Result} ({DateTime.Now})");
                    #endregion

                    // 累計計算總合
                    sum += task.Result;
                    var temp = allTasks.ToList();
                    // 將已經完成的工作，從清單中移除
                    temp.Remove(task);
                    allTasks = temp.ToArray();
                }

                Console.WriteLine($"計算總合為 {sum}");
            }
            catch (Exception exc)
            {
                // 當所有等候工作都執行結束後，可以檢查是否有執行失敗的工作
                foreach (Task faulted in allTasks.Where(t => t.IsFaulted))
                {
                    Console.WriteLine(faulted.Exception.InnerException.Message);
                }
            }

            Console.WriteLine($"結束執行三個非同步工作:{DateTime.Now}");
            Console.WriteLine("按下任一按鍵，結束處理程序");
            Console.ReadKey();
        }

        static async Task<int> 非同步工作委派方法Async(string url)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(url);
            return Convert.ToInt32(result);
        }
    }
}
