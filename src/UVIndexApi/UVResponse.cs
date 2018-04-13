using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UVIndexApi
{

    public class UVResponse
    {
        public Response result { get; set; }
    }

    public class Response
    {
        [JsonProperty(PropertyName = "uv")]
        public float UV { get; set; }
        [JsonProperty(PropertyName = "uv_time")]
        public DateTime UV_Time { get; set; }
        [JsonProperty(PropertyName = "uv_max")]
        public float UV_Max { get; set; }
        [JsonProperty(PropertyName = "uv_max_time")]
        public DateTime UV_Max_Time { get; set; }
        [JsonProperty(PropertyName = "ozone")]
        public float Ozone { get; set; }
        [JsonProperty(PropertyName = "ozone_time")]
        public DateTime Ozone_Time { get; set; }
    }

}
