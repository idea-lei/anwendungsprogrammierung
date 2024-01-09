using System.Net.Http;
using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        //AsyncFunc();
        //TestHttpWIthAsync().Wait();
        TestHttpWIthAsync().Wait();
        AsyncFunc().Wait();
        Console.WriteLine("after AsyncFunc");
    }

    // async await
    // for http or file operation...
    private static async Task AsyncFunc()
    {
        Console.WriteLine("Start waiting");
        await Task.Delay(3000);
        Console.WriteLine("time up");
    }

    private static async Task TestHttpWIthAsync()
    {
        Console.WriteLine("start http");
        string url = "https://www.google.com/";
        using (HttpClient client = new HttpClient())
        {
            var result = await client.GetAsync(url);
            if (result.IsSuccessStatusCode)
            {
                Console.WriteLine(await result.Content.ReadAsStringAsync());
            }
            else
            {
                Console.WriteLine("Http fehlt");
            }
        }

    }
}

// delegat
// reflection
// ...