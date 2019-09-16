using System;
using System.Net.Http;

namespace UseApi
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53756/api/");

                //HTTPGET

                var responseTask = client.GetAsync("salary");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
