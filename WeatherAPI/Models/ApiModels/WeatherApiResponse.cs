using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherAPI.Models.ApiModels
{
    internal class WeatherApiResponse
    {
        [JsonPropertyName("location")]
        public WeatherApiResponseLocation Location { get; set; }
        [JsonPropertyName("current")]
        public WeatherApiResponseCurrent Current { get; set; }
    }



    public class WeatherApiResponseLocation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("region")]
        public string Region { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("lat")]
        public float Lat { get; set; }
        [JsonPropertyName("lon")]
        public float Lon { get; set; }
        [JsonPropertyName("tz_id")]
        public string Tz_id { get; set; }
        [JsonPropertyName("localtime_epoch")]
        public int Localtime_epoch { get; set; }
        [JsonPropertyName("localtime")]
        public string Localtime { get; set; }
    }

    public class WeatherApiResponseCurrent
    {
        [JsonPropertyName("last_updated_epoch")]
        public int Last_updated_epoch { get; set; }
        [JsonPropertyName("last_updated")]
        public string Last_updated { get; set; }
        [JsonPropertyName("temp_c")]
        public float Temp_c { get; set; }
        [JsonPropertyName("temp_f")]
        public float Temp_f { get; set; }
        [JsonPropertyName("is_day")]
        public int Is_day { get; set; }
        [JsonPropertyName("condition")]
        public Condition Condition { get; set; }
        [JsonPropertyName("wind_mph")]
        public float Wind_mph { get; set; }
        [JsonPropertyName("wind_kph")]
        public float Wind_kph { get; set; }
        [JsonPropertyName("wind_degree")]
        public int Wind_degree { get; set; }
        [JsonPropertyName("wind_dir")]
        public string Wind_dir { get; set; }
        [JsonPropertyName("pressure_mb")]
        public float Pressure_mb { get; set; }
        [JsonPropertyName("pressure_in")]
        public float Pressure_in { get; set; }
        [JsonPropertyName("precip_mm")]
        public float Precip_mm { get; set; }
        [JsonPropertyName("precip_in")]
        public float Precip_in { get; set; }
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
        [JsonPropertyName("cloud")]
        public int Cloud { get; set; }
        [JsonPropertyName("feelslike_c")]
        public float Feelslike_c { get; set; }
        [JsonPropertyName("feelslike_f")]
        public float Feelslike_f { get; set; }
        [JsonPropertyName("vis_km")]
        public float Vis_km { get; set; }
        [JsonPropertyName("vis_miles")]
        public float Vis_miles { get; set; }
        [JsonPropertyName("uv")]
        public float Uv { get; set; }
        [JsonPropertyName("gust_mph")]
        public float Gust_mph { get; set; }
        [JsonPropertyName("gust_kph")]
        public float Gust_kph { get; set; }
    }

    public class Condition
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }

}
