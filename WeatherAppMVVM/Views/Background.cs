using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppMVVM.Models;
using WeatherAppMVVM.ViewModels;

namespace WeatherAppMVVM.Views
{
    public class Background
    {
        public static void changeBackground(Total forecast)
        {
            if (forecast.ForecastNow.Summary == "Clear")
            {
                WeatherViewModel._backgroundImage = "Images/clear.jpg";
            }
            else if (forecast.ForecastNow.Summary == "Partly Cloudy")
            {
                WeatherViewModel._backgroundImage = "Images/partlycloudy.jpg";
            }
            else if (forecast.ForecastNow.Summary == "Mostly Cloudy")
            {
                WeatherViewModel._backgroundImage = "Images/mostlycloudy.jpg";
            }
            else if (forecast.ForecastNow.Summary == "Overcast")
            {
                WeatherViewModel._backgroundImage = "Images/overcast.jpg";
            }
            else if (forecast.ForecastNow.Summary == "Drizzle")
            {
                WeatherViewModel._backgroundImage = "Images/drizzle.jpg";
            }
        }
    }
}
