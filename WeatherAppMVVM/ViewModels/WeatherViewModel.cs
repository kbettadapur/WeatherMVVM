using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppMVVM.Models;



namespace WeatherAppMVVM.ViewModels
{
    public class WeatherViewModel : ViewModel
    {
        public Total CurrentForecast { get; set; }
        public string City { get; set; }
        public RelayCommand LoadForecastCommand { get; set; }
        public static string _backgroundImage = "http://cdn.tripwiremagazine.com/wp-content/uploads/2011/07/DarkBlue.jpg";
        public string BackgroundImage
        {
            get { return _backgroundImage; }
            set { _backgroundImage = value; }
        }

        public WeatherViewModel()
        {
            LoadForecastCommand = new RelayCommand(LoadForecast);
        }

        public void ChangeBackground()
        {
            if (CurrentForecast.ForecastNow.Summary == "Clear")
            {
                _backgroundImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdydX6_Wl7HhliWCDnvWMJmI1hx6E_YFWfBEhA3foTh8iFg6Mleg";
            }

            else if (CurrentForecast.ForecastNow.Summary == "Partly Cloudy")
            {
                _backgroundImage = "http://img.astana.kz/c/759f0a5852ba1953c79335c327c9141e/600/450/3/1/7/1/5/9443ff8bc1d225c980a3225be78.png";
            }

            else if (CurrentForecast.ForecastNow.Summary == "Mostly Cloudy")
            {
                _backgroundImage = "http://www.wired.com/wp-content/uploads/blogs/insights/wp-content/uploads/2012/11/clouds_660.jpg";
            }
        }

        private void LoadForecast(object parameter)
        {
            if (City != "" && City != null)
            {
                var c = ForecastApi.getCoordinates(City);
                var f = ForecastApi.getForecast(c);
                CurrentForecast = f;
                OnPropertyChanged("CurrentForecast");
                OnPropertyChanged("City");
                ChangeBackground();
                OnPropertyChanged("BackgroundImage");

            }
        }
    }
}

