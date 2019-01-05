using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Components;
using PageLoadingOverlay.App.Helpers;

namespace PageLoadingOverlay.App.Features.Component3
{
    public class Component3Model: BlazorComponent, ILoadableComponent
    {
        [Parameter] protected LoadStateManager LoadStateManager { get; set; }

        public string Title => "Component 3";
        
        public string Status { get; private set; }
        
        public ComponentLoadState LoadState { get; } = new ComponentLoadState();

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            // Register this component with the LoadStateManager
            LoadStateManager.Register(this);
        }

        protected override async Task OnInitAsync()
        {
            // Simulate a web service call to get data
            await Task.Delay(3000);

            Status = StringConstants.RandomText;

            // Ok - we're done loading. Notify the LoadStateManager!
            LoadState.OnLoadingComplete();
        }
    }
}
