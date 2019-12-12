using BlazorStandalone.Core3.Data;
using System.Collections.Generic;

namespace BlazorStandalone.Core3
{
    public class MyState
    {
        public string Location { get; set; }
        public int Count { get; set; }
        public IEnumerable<WeatherForecast> Forecasts { get; set; }
    }
}