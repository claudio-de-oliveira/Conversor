using Conversor.Atributos;
using Conversor.Propriedades;

using System.Drawing;

namespace Conversor.Xml
{
    internal class XWindow : XContentControl
    {
        public readonly static new Dictionary<string, string> Properties = new () 
        {
            { "AllowsTransparency", "Gets or sets a value that indicates whether a window's client area supports transparency." }, // bool 
            { "DialogResult", "Gets or sets the dialog result value, which is the value that is returned from the System.Windows.Window.ShowDialog method." }, // DialogResult?
            { "Icon", "Gets or sets a window's icon." }, // ImageSource 
            { "Left", "Gets or sets the position of the window's left edge, in relation to the desktop." }, // double 
            { "Owner", "Gets or sets the System.Windows.Window that owns this System.Windows.Window." }, // Window 
            { "ResizeMode", "Gets or sets the resize mode." }, // ResizeMode 
            { "SizeToContent", "Gets or sets a value that indicates whether a window will automatically size itself to fit the size of its content." }, // SizeToContent 
            { "ShowActivated", "Gets or sets a value that indicates whether a window is activated when first shown." }, // bool 
            { "ShowInTaskbar", "Gets or sets a value that indicates whether the window has a task bar button." }, // bool 
            { "TaskbarItemInfo", "Gets or sets the Windows 7 taskbar thumbnail for the System.Windows.Window." }, // TaskbarItemInfo 
            { "ThemeMode", "Gets or sets the Fluent theme mode of the window." },
            { "Title", "Gets or sets a window's title." }, // string 
            { "Top", "Gets or sets the position of the window's top edge, in relation to the desktop." }, // double 
            { "Topmost", "Gets or sets a value that indicates whether a window appears in the topmost z-order." }, // bool 
            { "WindowStartupLocation", "Gets or sets the position of the window when first shown." }, // WindowStartupLocation 
            { "WindowState", "Gets or sets a value that indicates whether a window is restored, minimized, or maximized." }, // WindowState 
            { "WindowStyle", "Gets or sets a window's border style." }, // WindowStyle 
        };

        #region Attributes
        public Dictionary<string, object> Attributes { get; set; } = [];
        public Dictionary<string, object> Children { get; set; } = [];
        #endregion

        #region Properties
        public bool AllowsTransparency { get; set; }
        public bool? DialogResult { get; set; }
        public XImageSource Icon { get; set; }
        public double Left { get; set; }
        public XWindow Owner { get; set; }
        public XResizeMode ResizeMode { get; set; }
        public XSizeToContent SizeToContent { get; set; }
        public bool ShowActivated { get; set; }
        public bool ShowInTaskbar { get; set; }
        public XTaskbarItemInfo TaskbarItemInfo { get; set; }
        public XThemeMode ThemeMode { get; set; }
        public string Title { get; set; }
        public double Top { get; set; }
        public bool Topmost { get; set; }
        public XWindowStartupLocation WindowStartupLocation { get; set; }
        public XWindowState WindowState { get; set; }
        public XWindowStyle WindowStyle { get; set; }
        #endregion

        public static new string? FindXmlElement(string key)
        {
            if (Properties.ContainsKey(key))
                return Properties[key];
            return XContentControl.FindXmlElement(key);
        }
    }
}
