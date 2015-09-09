using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAppMVVM.Models
{
    public class DailyData
    {
        [JsonProperty("time")]
        public long UnixTime { get; set; }
        public string Time
        {
            get { return FromUnixTime(UnixTime).ToString("MM/dd"); }
        }

        [JsonProperty("temperatureMin")]
        public double DoubleMinimumTemperature { get; set; }
        public int MinimumTemperature
        {
            get { return (int)DoubleMinimumTemperature; }
        }

        [JsonProperty("temperatureMax")]
        public double DoubleMaximumTemperature { get; set; }
        public int MaximumTemperature
        {
            get { return (int)DoubleMaximumTemperature; }
        }

        public DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
    }
}
