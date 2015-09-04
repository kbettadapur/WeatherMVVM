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
        public double doubleTemperature { get; set; }
        public int Temperature
        {
            get { return (int)doubleTemperature; }
            set{ doubleTemperature = value; }
        }

        [JsonProperty("apparentTemperature")]
        public double doubleApparentTemperature { get; set; }
        public int ApparentTemperature
        {
            get { return (int)doubleApparentTemperature; }
            set { doubleApparentTemperature = value; }
        }
        
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
        [JsonProperty("precipProbability")]
        public double RainChanceDecimal { get; set; }
        

        public double RainChance
        {
            get { return (RainChanceDecimal * 100); }
        }

        public DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
    }
}
