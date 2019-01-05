using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Components;
using PageLoadingOverlay.App.Helpers;

namespace PageLoadingOverlay.App.Features.LoadingOverlay
{
    /// <summary>
    /// Model class for <see cref="LoadingOverlayView"/>
    /// </summary>
    public class LoadingOverlayModel: BlazorComponent
    {
        /// <summary>
        /// The <see cref="LoadStateManager"/> for this <see cref="LoadingOverlayModel"/>
        /// </summary>
        [Parameter] protected LoadStateManager LoadStateManager { get; set; }

        protected override async Task OnInitAsync()
        {
            // When LoadStateManager indicates that all components are loaded, notify
            // this component of the state change
            LoadStateManager.LoadingComplete += (sender, args) => StateHasChanged();

            await Task.CompletedTask;
        }
    }
}
