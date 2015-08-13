using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAppMVVM.Models
{
    public class Coordinates
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }
}
