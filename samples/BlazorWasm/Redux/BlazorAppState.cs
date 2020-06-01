using BlazorWasm.Data;
using System.Collections.Generic;

namespace BlazorWasm
{
    public class BlazorAppState
    {
        public string Location { get; set; }
        public int Count { get; set; }
        public IEnumerable<WeatherForecast> Forecasts { get; set; }
    }
}