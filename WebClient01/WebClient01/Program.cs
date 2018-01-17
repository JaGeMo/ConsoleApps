using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace WebClient01
{
    class Program
    {
        #region HttpClient
        static HttpClient client = new HttpClient();
        #endregion

        #region GetResponseAsync
        static async Task<string> GetResponseAsync(Uri url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string responseString = "";

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }
            return responseString;
        }
        #endregion

        #region Main
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }
        #endregion

        #region RunAsync
        static async Task RunAsync()
        {
            // potential port tba
            client.BaseAddress = new Uri("http://google.de");
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Get the product
                string result = await GetResponseAsync(client.BaseAddress);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    #endregion
    }
}