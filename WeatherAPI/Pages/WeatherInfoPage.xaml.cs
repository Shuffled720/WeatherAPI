using WeatherAPI.Models.ViewModels;

namespace WeatherAPI.Pages;

public partial class WeatherInfoPage : ContentPage
{
    public WeatherInfoPage()
    {
        InitializeComponent();
        BindingContext = new WeatherInfoPageViewModel();
    }
}