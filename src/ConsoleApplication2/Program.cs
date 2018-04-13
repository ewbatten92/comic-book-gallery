using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://openexchangerates.org/api/latest.json?app_id=1808ffe328a046d3be16c65005c59902 ";
            var currencyRates = _download_serialized_json_data<CurrencyRates>(url);
            Console.WriteLine();
        }
        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
        public class CurrencyRates
        {
            public string Disclaimer { get; set; }
            public string License { get; set; }
          //  public int TimeStamp { get; set; }
         //   public string Base { get; set; }
         //   public Dictionary<string, decimal> Rates { get; set; }
        }
    }
}
