namespace PageLoadingOverlay.App.Helpers
{
    /// <summary>
    /// Defines a component whose <see cref="ComponentLoadState"/> can be managed by a <see cref="LoadStateManager"/>
    /// </summary>
    public interface ILoadableComponent
    {
        /// <summary>
        /// The load state of a component
        /// </summary>
        ComponentLoadState LoadState { get; }
    }
}
