using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAppMVVM.Models
{
    public class Hourly
    {
        [JsonProperty("Data")]
        public List<HourlyData> HourlyDataPoints { get; set; }
    }
}
