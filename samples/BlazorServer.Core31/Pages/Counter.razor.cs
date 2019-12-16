using System;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Core31.Pages
{
    public partial class Counter : MyAppComponent
    {
        private void IncrementCount()
        {
            Dispatch(new IncrementByValueAction(1));
        }
    }
}
