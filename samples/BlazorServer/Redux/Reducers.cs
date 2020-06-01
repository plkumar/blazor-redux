﻿using System;
using System.Collections.Generic;
using BlazorRedux;
using BlazorServer.Data;

namespace BlazorServer
{
    public static class Reducers
    {
        public static BlazorAppState RootReducer(BlazorAppState state, IAction action)
        {
            if (state == null)
                throw new ArgumentNullException(nameof(state));

            return new BlazorAppState
            {
                Location = Location.Reducer(state.Location, action),
                Count = CountReducer(state.Count, action),
                Forecasts = ForecastsReducer(state.Forecasts, action)
            };
        }

        private static int CountReducer(int count, IAction action)
        {
            switch (action)
            {
                case IncrementByOneAction _:
                    return count + 1;
                case IncrementByValueAction a:
                    return count + a.Value;
                default:
                    return count;
            }
        }

        private static IEnumerable<WeatherForecast> ForecastsReducer(IEnumerable<WeatherForecast> forecasts,
            IAction action)
        {
            switch (action)
            {
                case ClearWeatherAction _:
                    return null;
                case ReceiveWeatherAction a:
                    return a.Forecasts;
                default:
                    return forecasts;
            }
        }
    }
}