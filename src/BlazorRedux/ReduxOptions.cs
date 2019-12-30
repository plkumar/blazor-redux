using System;
using System.Text.Json;

namespace BlazorRedux
{
    public class ReduxOptions<TState>
    {
        public ReduxOptions()
        {
            // Defaults
            StateSerializer = state => JsonSerializer.Serialize(state);
            StateDeserializer = JsonSerializer.Deserialize<TState>;
        }
        
        public Reducer<TState, NewLocationAction> LocationReducer { get; set; }
        public Func<TState, string> GetLocation { get; set; }
        public Func<TState, string> StateSerializer { get; set; }
        public Func<string, JsonSerializerOptions, TState> StateDeserializer { get; set; }
    }
}