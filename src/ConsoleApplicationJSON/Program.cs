using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient Client = new WebClient();
            var json = Client.DownloadString("https://www.metaweather.com/api/location/2487889/");
            var myObj = JsonConvert.DeserializeObject<ForeCasts>(json);
            foreach(var ob in myObj.consolidated_weather)
            {
                Console.WriteLine(ob.air_pressure);
            }
            Console.ReadLine();

        }
    }
}
