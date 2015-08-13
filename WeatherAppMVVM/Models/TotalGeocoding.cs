using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAppMVVM.Models
{
    public class TotalGeocoding
    {
        [JsonProperty("results")]
        public List<GeocodingResults> Results { get; set; }
    }
}
