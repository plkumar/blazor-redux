﻿using System.Collections.Generic;
using BlazorRedux;
using BlazorStandalone.Core3.Data;

namespace BlazorStandalone.Core3
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