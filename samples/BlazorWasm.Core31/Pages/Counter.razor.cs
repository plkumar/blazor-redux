using System;
namespace BlazorWasm.Core31.Pages
{
    public partial class Counter 
    {
        private void IncrementCount()
        {
            Dispatch(new IncrementByValueAction(1));
        }
    }
}
