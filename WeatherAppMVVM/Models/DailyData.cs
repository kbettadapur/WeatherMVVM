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

        [JsonProperty("icon")]
        public string _iconSource { get; set; }
        public string IconSource
        {
            get { return iconSetter(_iconSource); }
            set { _iconSource = value; }
        }
        
        public string iconSetter(string icon)
        {
            if (icon == "clear-day")
                return "Images/clearicon.png";
            else if (icon == "rain")
                return "Images/rainicon.png";
            else if (icon == "partly-cloudy-day")
                return "Images/partlycloudyicon.png";
            else if (icon == "cloudy")
                return "Images/cloudyicon.png";
            else
                return null;
            
        }

        public DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
    }
}
