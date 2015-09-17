using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAppMVVM.Models
{
    public class Total
    {
        [JsonProperty("currently")]
        public Currently ForecastNow { get; set; }
        [JsonProperty("daily")]
        public Daily ForecastDaily { get; set; }
        [JsonProperty("hourly")]
        public Hourly ForecastHourly { get; set; }
    }
}
