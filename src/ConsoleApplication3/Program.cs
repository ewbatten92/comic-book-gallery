using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

 
            String response = null;    

            try
            {
                WebClient webClient = new WebClient();
                Stream stream = webClient.OpenRead("google.com");
               
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                {
                    switch (((HttpWebResponse)ex.Response).StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            response = null;
                            break;

                        default:
                            throw ex;
                    }
                }
            }
        }
        
    }
}
