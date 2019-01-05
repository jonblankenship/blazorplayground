using Microsoft.AspNetCore.Blazor.Components;
using PageLoadingOverlay.App.Helpers;

namespace PageLoadingOverlay.App.Features.Home
{
    public class IndexModel: BlazorComponent
    {
        /// <summary>
        /// The <see cref="LoadStateManager"/> for this view
        /// </summary>
        /// <remarks>
        /// Since this is the parent view that contains the loading overlay, we new
        /// up an instance of the <see cref="LoadStateManager"/> here, and pass it
        /// to child components.
        /// </remarks>
        public LoadStateManager LoadStateManager { get; } = new LoadStateManager();
    }
}
