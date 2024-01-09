using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace apiProjektClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                Console.ReadLine();
                TestRequest().Wait();
            }
        }

        private static async Task TestRequest()
        {
            using(var http = new HttpClient())
            {
                string url = "https://localhost:44337/api";
                string urlStudent = $"{url}/Students";
                var student = new Student
                {
                    Name = "ABC",
                    Id = "0123465",
                    Fach = "Test Fach"
                };
                var requestBody = new StringContent(JsonConvert.SerializeObject(student), encoding: Encoding.UTF8, mediaType: "application/json");
                var result = await http.PostAsync(urlStudent, requestBody);
                //var result = await http.GetAsync(urlStudent);
                if (result.IsSuccessStatusCode)
                {
                    string resultContentString = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(resultContentString);
                }
                else
                {
                    Console.WriteLine(result.StatusCode);
                }
            }
        }

        public class Student
        {
            public string Id { get; set; } //MatNr
            public string Name { get; set; }
            public string Fach { get; set; }
        }
    }
}
