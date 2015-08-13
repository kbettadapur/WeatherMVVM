using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAppMVVM.Models
{
    public class Currently
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }
        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }
        [JsonProperty("time")]
        public long EnochTime { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }
        [JsonProperty("humidity")]
        public double Humidity { get; set; }
        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        public DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
    }
}
