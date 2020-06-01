using System;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages
{
    public partial class Counter : MyAppComponent
    {
        private void IncrementCount()
        {
            Dispatch(new IncrementByValueAction(1));
        }
    }
}
