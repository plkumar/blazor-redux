using BlazorServer.Core31.Data;
using System.Collections.Generic;

namespace BlazorServer.Core31
{
    public class BlazorAppState
    {
        public string Location { get; set; }
        public int Count { get; set; }
        public IEnumerable<WeatherForecast> Forecasts { get; set; }
    }
}