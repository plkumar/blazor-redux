using System;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public partial class FetchData : MyAppComponent
    {

        protected override async Task OnInitializedAsync()
        {
            await ActionCreators.LoadWeather(Store.Dispatch, Http);
        }
    }

}
