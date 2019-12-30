using System.Net.Http;
using System.Threading.Tasks;
using BlazorRedux;
using System.Text.Json;
using BlazorWasm.Core31.Data;

namespace BlazorWasm.Core31
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