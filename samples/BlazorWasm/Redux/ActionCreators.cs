using System.Net.Http;
using System.Threading.Tasks;
using BlazorRedux;
using BlazorWasm.Data;
using System.Text.Json;
using System;

namespace BlazorWasm
{
    public static class ActionCreators
    {
        public static async Task LoadWeather(Dispatcher<IAction> dispatch)
        {
            dispatch(new ClearWeatherAction());

            var forecasts = await new WeatherForecastService().GetForecastAsync(DateTime.Now);

            dispatch(new ReceiveWeatherAction
            {
                Forecasts = forecasts
            });
        }
    }
}