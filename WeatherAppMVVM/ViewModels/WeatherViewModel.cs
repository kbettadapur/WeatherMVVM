using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppMVVM.Models;
using WeatherAppMVVM.Views;


namespace WeatherAppMVVM.ViewModels
{
    public class WeatherViewModel : ViewModel
    {
        public Total CurrentForecast { get; set; }
        public string City { get; set; }
        public RelayCommand LoadForecastCommand { get; set; }
        public static string _backgroundImage = "Images/defaultblue.jpg";
        public string BackgroundImage
        {
            get { return _backgroundImage; }
            set { _backgroundImage = value; }
        }

        

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
                CurrentForecast = f;
                OnPropertyChanged("CurrentForecast");
                OnPropertyChanged("City");
                Background.changeBackground(CurrentForecast);
                OnPropertyChanged("BackgroundImage");
            }
        }
    }
}

