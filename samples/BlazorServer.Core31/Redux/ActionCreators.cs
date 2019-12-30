using System.Net.Http;
using System.Threading.Tasks;
using BlazorRedux;
using BlazorServer.Core31.Data;
using System.Text.Json;

namespace BlazorServer.Core31
{
    public static class ActionCreators
    {
        public static async Task LoadWeather(Dispatcher<IAction> dispatch, HttpClient http)
        {
            dispatch(new ClearWeatherAction());
            var forecastData = await http.GetStringAsync("/sample-data/weather.json");

            var forecasts = JsonSerializer.Deserialize<WeatherForecast[]>(forecastData);

            dispatch(new ReceiveWeatherAction
            {
                Forecasts = forecasts
            });
        }
    }
}