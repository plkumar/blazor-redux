using BlazorRedux;
using BlazorServer.Core31;
using BlazorServer.Core31.Data;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWasm.Core31
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
            services.AddReduxStore<BlazorAppState, IAction>(
                new BlazorAppState(), Reducers.RootReducer, options =>
                {
                    options.GetLocation = state => state.Location;
                });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
