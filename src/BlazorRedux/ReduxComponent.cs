﻿using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorRedux
{
    public class ReduxComponent<TState, TAction> : ComponentBase, IDisposable
    {
        [Inject] public Store<TState, TAction> Store { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        public TState State => Store.State;

        public RenderFragment ReduxDevTools;

        public void Dispose()
        {
            Store.Change -= OnChangeHandler;
        }

        protected override void OnInitialized()
        {
            Store.Init(NavigationManager);
            Store.Change += OnChangeHandler;

            ReduxDevTools = builder =>
            {
                var seq = 0;
                builder.OpenComponent<ReduxDevTools>(seq);
                builder.CloseComponent();
            };
            
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            var seq = 0;
            builder.OpenComponent<ReduxDevTools>(seq);
            builder.CloseComponent();
        }

        private void OnChangeHandler(object sender, EventArgs e)
        {
            StateHasChanged();
        }

        public void Dispatch(TAction action)
        {
            Store.Dispatch(action);
        }
    }
}