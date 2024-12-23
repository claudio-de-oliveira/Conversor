namespace Conversor.Xml
{
    internal class XUIElement
    {
        public readonly static Dictionary<string, string> Properties = new ()
        {
            { "Opacity", "Gets or sets the opacity factor applied to the entire System.Windows.UIElement when it is rendered in the user interface (UI). This is a dependency property." }, // double
            { "SnapsToDevicePixels", "Gets or sets a value that determines whether rendering for this element should use device-specific pixel settings during rendering. This is a dependency property." }, // bool
            { "RenderSize", "Gets (or sets) the final render size of this element." }, // Size
            { "RenderTransform", "Gets or sets transform information that affects the rendering position of this element. This is a dependency property." }, // Transform
            { "RenderTransformOrigin", "Gets or sets the center point of any possible render transform declared by System.Windows.UIElement.RenderTransform, relative to the bounds of the element. This is a dependency property." }, // Point
            { "OpacityMask", "Gets or sets an opacity mask, as a System.Windows.Media.Brush implementation that is applied to any alpha-channel masking for the rendered content of this element. This is a dependency property." }, // Brush
            { "Uid", "Gets or sets the unique identifier (for localization) for this element. This is a dependency property." }, // string
            { "Clip", "Gets or sets the geometry used to define the outline of the contents of an element. This is a dependency property." }, // Geometry
            { "AllowDrop", "Gets or sets a value indicating whether this element can be used as the target of a drag-and-drop operation. This is a dependency property." }, // bool
            { "IsManipulationEnabled", "Gets or sets a value that indicates whether manipulation events are enabled on this System.Windows.UIElement." }, // bool
            { "Focusable", "Gets or sets a value that indicates whether the element can receive focus. This is a dependency property." }, // bool
            { "IsEnabled", "Gets or sets a value indicating whether this element is enabled in the user interface (UI). This is a dependency property." }, // bool
            { "IsHitTestVisible", "Gets or sets a value that declares whether this element can possibly be returned as a hit test result from some portion of its rendered content. This is a dependency property." }, // bool
            { "Effect", "Gets or sets the bitmap effect to apply to the System.Windows.UIElement. This is a dependency property." }, // Effect
            { "Visibility", "Gets or sets the user interface (UI) visibility of this element. This is a dependency property." }, // Visibility
            { "ClipToBounds", "Gets or sets a value indicating whether to clip the content of this element (or content coming from the child elements of this element) to fit into the size of the containing element. This is a dependency property." }, // bool
        };

        public static string? FindXmlElement(string key)
        {
            if (Properties.ContainsKey(key))
                return Properties[key];
            return null;
        }
    }
}
