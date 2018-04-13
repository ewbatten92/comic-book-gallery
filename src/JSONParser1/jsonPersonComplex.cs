using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
{ 
  "firstname" : "Roger",
  "lastname" : "Moore",
  "age" : 89,
  "isAlive": false,
	"address": {
	"streetAddress": "1 Main Street",
	"city": "London",
	"postCode":"N1 3XX"
 }
}
*/
namespace JSONParser1
{
    class jsonPersonComplex : jsonPersonSimple
    {
        /*
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public bool isAlive { get; set; }
        */
        public addr address { get; set; }

        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string postCode { get; set; }
        }
    }
}
