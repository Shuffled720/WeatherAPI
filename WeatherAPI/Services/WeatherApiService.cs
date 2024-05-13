using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.Models.ApiModels;

namespace WeatherAPI.Services
{
    internal class WeatherApiService
    {
        private readonly HttpClient _httpClient;
        public WeatherApiService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(Constants.BaseUrl) };
        }
        public async Task<WeatherApiResponse?> GetWeatherInformation(string latitude, string longitude)
        {
            try
            {
                if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                {
                    return null;
                }
                return await _httpClient.GetFromJsonAsync<WeatherApiResponse>($"?key={Constants.ApiKey}&q={latitude},{longitude}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
