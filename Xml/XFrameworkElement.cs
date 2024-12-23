namespace Conversor.Xml
{
    internal class XFrameworkElement : XUIElement
    {
        public readonly static new Dictionary<string, string> Properties = new ()
        {
            { "ActualHeight", "ActualHeight." }, // double
            { "Name", "Name." }, // string
            { "ActualWidth", "ActualWidth." }, // double
            { "Language", "Gets or sets localization/globalization language information that applies to an element." }, // XmlLanguage
            { "LayoutTransform", "Gets or sets a graphics transformation that should apply to this element when layout is performed." }, // Transform
            { "Margin", "Gets or sets the outer margin of an element." }, // Thickness
            { "MinWidth", "Gets or sets the minimum width constraint of the element." }, // double
            { "MaxWidth", "Gets or sets the maximum width constraint of the element." }, // double
            { "MinHeight", "Gets or sets the minimum height constraint of the element." }, // double
            { "MaxHeight", "Gets or sets the maximum height constraint of the element." }, // double
            { "ContextMenu", "Gets or sets the context menu element that should appear whenever the context menu is requested through user interface (UI) from within this element." }, // ContextMenu
            { "HorizontalAlignment", "Gets or sets the horizontal alignment characteristics applied to this element when it is composed within a parent element, such as a panel or items control." }, // HorizontalAlignment
            { "Height", "Gets or sets the suggested height of the element." }, // double
            { "ForceCursor", "Gets or sets a value that indicates whether this System.Windows.FrameworkElement should force the user interface (UI) to render the cursor as declared by the System.Windows.FrameworkElement.Cursor property." }, // bool
            { "FocusVisualStyle", "Gets or sets a property that enables customization of appearance, effects, or other style characteristics that will apply to this element when it captures keyboard focus." }, // Style
            { "FlowDirection", "Gets or sets the direction that text and other user interface (UI) elements flow within any parent element that controls their layout." }, // FlowDirection
            { "DataContext", "Gets or sets the data context for an element when it participates in data binding." }, // object
            { "Cursor", "Gets or sets the cursor that displays when the mouse pointer is over this element." }, // Cursor
            { "BindingGroup", "Gets or sets the System.Windows.Data.BindingGroup that is used for the element." }, // BindingGroup
            { "InputScope", "Gets or sets the context for input used by this System.Windows.FrameworkElement." }, // InputScope
            { "OverridesDefaultStyle", "Gets or sets a value that indicates whether this element incorporates style properties from theme styles." }, // bool
            { "Resources", "Gets or sets the locally-defined resource dictionary." }, // ResourceDictionary
            { "Style", "Gets or sets the style used by this element when it is rendered." }, // Style
            { "Tag", "Gets or sets an arbitrary object value that can be used to store custom information about this element." }, // object
            { "ToolTip", "Gets or sets the tool-tip object that is displayed for this element in the user interface (UI)." }, // object
            { "UseLayoutRounding", "Gets or sets a value that indicates whether layout rounding should be applied to this element's size and position during layout." }, // bool
            { "VerticalAlignment", "Gets or sets the vertical alignment characteristics applied to this element when it is composed within a parent element such as a panel or items control." }, // VerticalAlignment
            { "Width", "Gets or sets the width of the element." }, // double
        };

        public static new string? FindXmlElement(string key)
        {
            if (Properties.ContainsKey(key))
                return Properties[key];
            return XUIElement.FindXmlElement(key);
        }
    }
}
