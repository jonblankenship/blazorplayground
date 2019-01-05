using System;
using System.Collections.Generic;
using System.Linq;

namespace PageLoadingOverlay.App.Helpers
{
    /// <summary>
    /// Manages the <see cref="ComponentLoadState"/>s for a particular view
    /// </summary>
    public class LoadStateManager
    {
        private readonly ICollection<ComponentLoadState> _componentLoadStates = new List<ComponentLoadState>();
        
        /// <summary>
        /// Gets a value indicating whether all registered components are loaded
        /// </summary>
        public bool IsLoadingComplete => _componentLoadStates.All(c => c.IsLoaded);

        /// <summary>
        /// Registers an <see cref="ILoadableComponent"/> with this <see cref="LoadStateManager"/>
        /// </summary>
        /// <param name="component"></param>
        public void Register(ILoadableComponent component)
        {
            _componentLoadStates.Add(component.LoadState);

            component.LoadState.LoadingComplete += (sender, args) =>
            {
                if (IsLoadingComplete) OnLoadingComplete();
            };
        }

        /// <summary>
        /// Notifies subscribers that all loading is complete for all registered components
        /// </summary>
        public event EventHandler LoadingComplete;
        
        protected void OnLoadingComplete()
        {
            LoadingComplete?.Invoke(this, new EventArgs());
        }
    }
}
