using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.Services;

namespace WeatherAPI.Models.ViewModels
{
    internal partial class WeatherInfoPageViewModel : ObservableObject
    {
        private readonly WeatherApiService _weatherApiService;

        public WeatherInfoPageViewModel()
        {
            _weatherApiService = new WeatherApiService();
        }

        [ObservableProperty]
        private string latitude;

        [ObservableProperty]
        private string longitude;

        [ObservableProperty]
        private string weatherIcon;

        [ObservableProperty]
        private string temperature;

        [ObservableProperty]
        private string weatherDescription;

        [ObservableProperty]
        private string isDay;

        [ObservableProperty]
        private string location;

        [ObservableProperty]
        private string humidity;

        [ObservableProperty]
        private string cloudCoverLevel;

        [RelayCommand]
        private async Task GetWeatherInfo()
        {
            Console.WriteLine("GetWeatherInfo");
            // Get weather info

            var weatherApiResponse = await _weatherApiService.GetWeatherInformation(Latitude, Longitude);
            if (weatherApiResponse != null)
            {
                WeatherIcon = weatherApiResponse.Current.Condition.Icon;
                Temperature = $"{weatherApiResponse.Current.Temp_c}°C";
                WeatherDescription = weatherApiResponse.Current.Condition.Text;
                IsDay = weatherApiResponse.Current.Is_day == 1 ? "Day" : "Night";
                Location = weatherApiResponse.Location.Name;
                Humidity = $"{weatherApiResponse.Current.Humidity}%";
                CloudCoverLevel = $"{weatherApiResponse.Current.Cloud}%";


            }

        }
    }
}
