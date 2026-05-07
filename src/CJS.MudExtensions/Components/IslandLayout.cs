namespace CJS.MudExtensions.Components;

public enum IslandLayout
{
    /// <summary>
    /// Size to content (default). The page is responsible for scrolling.
    /// </summary>
    Content = 0,

    /// <summary>
    /// Fill available space and allow internal scrolling.
    /// </summary>
    FillAndScroll = 1,

    /// <summary>
    /// Fill available space but do not scroll (content may be clipped).
    /// </summary>
    FillNoScroll = 2,
}