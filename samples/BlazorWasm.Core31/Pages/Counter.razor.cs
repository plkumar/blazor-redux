using System;
namespace BlazorWasm.Core31.Pages
{
    public partial class Counter 
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            Dispatch(new IncrementByValueAction(1));
        }
    }
}
