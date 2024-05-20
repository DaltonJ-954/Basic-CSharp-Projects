using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            string url = "";

            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://openlibrary.org/works/OL45804W/editions.json");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine($"Response error code: {response.StatusCode}");
                }
            }

            Console.ReadLine();
        }
    }
}
