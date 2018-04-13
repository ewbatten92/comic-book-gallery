using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace UVIndexApi
{
    class Program
    {
        static void Main(string[] args)
        {
            PostRequest("https://www.google.com/");
            //GetRequest("http://www.google.com.pk");



            Console.ReadKey();
        }
        async static void GetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                //why do we need our own method and why do we need the await 
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myconent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                        
                        Console.WriteLine(content);
                        
                    }
                }                    
            }
        }
        async static void PostRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("query1","Ethan"),
                    new KeyValuePair<string, string>("query1","Batten")
                };
                HttpContent q = new FormUrlEncodedContent(queries);
                //why do we need our own method and why do we need the await 
                using (HttpResponseMessage response = await client.PostAsync(url,q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;

                        Console.WriteLine(mycontent);

                    }
                }
            }
        }







    }
}
