using System;

namespace PageLoadingOverlay.App.Helpers
{
    /// <summary>
    /// Represents the load state of an individual component
    /// </summary>
    public class ComponentLoadState
    {
        /// <summary>
        /// Gets a value indicating whether this component is loaded
        /// </summary>
        public bool IsLoaded { get; private set; }

        /// <summary>
        /// Notifies the <see cref="LoadStateManager"/> that this component has completed loading
        /// </summary>
        public event EventHandler LoadingComplete;

        /// <summary>
        /// Invoked by the corresponding component to indicate that it has completed loading
        /// </summary>
        public void OnLoadingComplete()
        {
            IsLoaded = true;
            LoadingComplete?.Invoke(this, new EventArgs());
        }
    }
}
