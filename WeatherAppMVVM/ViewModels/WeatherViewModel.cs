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


        public WeatherViewModel()
        {
            LoadForecastCommand = new RelayCommand(LoadForecast);
        }

        private void LoadForecast(object parameter)
        {
            if (City != "" && City != null)
            {
                var c = ForecastApi.getCoordinates(City);
                var f = ForecastApi.getForecast(c);
                string displayCity = City;
                CurrentForecast = f;
                OnPropertyChanged("CurrentForecast");
            }     }

        
        
    }
}
