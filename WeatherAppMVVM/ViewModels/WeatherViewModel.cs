using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppMVVM.Models;



namespace WeatherAppMVVM.ViewModels
{
    public class WeatherViewModel : ViewModel
    {
        public WeatherViewModel()
        {
            LoadForecastCommand = new RelayCommand(LoadForecast);
        }

        public Total CurrentForecast { get; set; }
        public string City { get; set; }
        public RelayCommand LoadForecastCommand { get; set; }

        public string _dailyForecastText;
        public string DailyForecastText
        {
            get { return _dailyForecastText; }
        }

        public string _hourlyForecastText;
        public string HourlyForecastText
        {
            get { return _hourlyForecastText; }
        }

                

        private void LoadForecast(object parameter)
        {
            if (City != "" && City != null)
            {
                var c = ForecastApi.getCoordinates(City);
                var f = ForecastApi.getForecast(c);
                CurrentForecast = f;
                
                _dailyForecastText = "Daily Forecast";
                _hourlyForecastText = "Hourly Forecast";
                OnPropertyChanged("CurrentForecast");
                OnPropertyChanged("City");
                OnPropertyChanged("Icon");
                OnPropertyChanged("DailyForecastText");
                OnPropertyChanged("HourlyForecastText");
            }
        }
    }
}

