﻿using System.Collections.Generic;
using BlazorRedux;
using BlazorServer.Core31.Data;

namespace BlazorServer.Core31
{
    public class IncrementByOneAction : IAction
    {
    }

    public class IncrementByValueAction : IAction
    {
        public IncrementByValueAction(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }

    public class ClearWeatherAction : IAction
    {
    }

    public class ReceiveWeatherAction : IAction
    {
        public IEnumerable<WeatherForecast> Forecasts { get; set; }
    }
}