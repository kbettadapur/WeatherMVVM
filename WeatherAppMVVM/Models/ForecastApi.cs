using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace WeatherAppMVVM.Models
{
    public class ForecastApi
    {
       

        public static Coordinates getCoordinates(string city)
        {
            var geocoder = new WebClient();
            string geocodeJson = geocoder.DownloadString("https://maps.googleapis.com/maps/api/geocode/json?address=" + city);
            TotalGeocoding totalGeocoding = JsonConvert.DeserializeObject<TotalGeocoding>(geocodeJson);
            return totalGeocoding.Results[0].Geometry.Location;
        }

        public static Total getForecast(Coordinates c)
        {
            var client = new WebClient();
            string jsonString = client.DownloadString("https://api.forecast.io/forecast/70c6d8448f6fc4a51c2ab2e4c4d2daeb/" + c.Latitude + "," + c.Longitude);
            Total totalForecast = JsonConvert.DeserializeObject<Total>(jsonString);
            return totalForecast;
        }
    }
}
