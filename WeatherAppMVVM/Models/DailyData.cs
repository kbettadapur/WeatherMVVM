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
            get { return FromUnixTime(UnixTime).ToString("MM/dd\n"); }
        }

        [JsonProperty("temperatureMin")]
        public double DoubleMinimumTemperature { get; set; }
        public string MinimumTemperature
        {
            get { return ((int)DoubleMinimumTemperature).ToString() + " °F\n"; }
        }

        [JsonProperty("temperatureMax")]
        public double DoubleMaximumTemperature { get; set; }
        public string MaximumTemperature
        {
            get { return ((int)DoubleMaximumTemperature).ToString() + " °F\n"; }
        }

        [JsonProperty("summary")]
        public string _summary { get; set; }

        public string Summary
        {
            get { return _summary + "\n"; }
            set { _summary = value; }
        }
        

        

        public DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
    }
}
