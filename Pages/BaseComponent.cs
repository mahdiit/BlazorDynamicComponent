using Microsoft.AspNetCore.Components;

namespace BlazorApp3.Pages
{
    public class BaseComponent: ComponentBase
    {
        [Parameter]
        public object Model { get; set; }

        [Parameter] 
        public EventCallback<object> GetModel { get; set; }
    }
}
