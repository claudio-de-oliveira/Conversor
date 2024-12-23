namespace Conversor.Xml
{
    internal class XControl : XFrameworkElement
    {
        public readonly static new Dictionary<string, string> Properties = new ()
        {
            { "FontWeight", "FontWeight" }, // FontWeight
            { "FontStyle", "FontStyle" }, // FontStyle
            { "FontStretch", "FontStretch" }, // FontStretch
            { "FontSize", "FontSize" }, // double
            { "FontFamily", "FontFamily" }, // FontFamily
            { "BorderThickness", "BorderThickness" }, // Thickness
            { "BorderBrush", "BorderBrush" }, // Brush
            { "Padding", "Padding" }, // Thickness
            { "HorizontalContentAlignment", "HorizontalContentAlignment" }, // HorizontalAlignment
            { "IsTabStop", "IsTabStop" }, // bool
            { "TabIndex", "TabIndex" }, // int
            { "Template", "Template" }, // ControlTemplate
            { "VerticalContentAlignment", "VerticalContentAlignment" }, // VerticalAlignment
            { "Foreground", "Foreground" }, // Brush
            { "Background", "Background" }, // Brush
        };

        public static new string? FindXmlElement(string key)
        {
            if (Properties.ContainsKey(key))
                return Properties[key];
            return XFrameworkElement.FindXmlElement(key);
        }
    }
}
