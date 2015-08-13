using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAppMVVM.Models
{
    public class Minutely
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}
