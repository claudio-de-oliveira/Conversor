namespace Conversor.Xml
{
    internal class XContentControl : XControl
    {
        public readonly static new Dictionary<string, string> Properties = new()
        {
            { "ContentTemplateSelector", "Gets or sets a template selector that enables an application writer to provide custom template-selection logic." }, // DataTemplateSelector 
            { "ContentTemplate", "Gets or sets the data template used to display the content of the System.Windows.Controls.ContentControl." }, // DataTemplate
            { "ContentStringFormat", "Gets or sets a composite string that specifies how to format the System.Windows.Controls.ContentControl.Content property if it is displayed as a string." }, // string 
            { "Content", "Gets or sets the content of a System.Windows.Controls.ContentControl." }, // object 
        };

        public static new string? FindXmlElement(string key)
        {
            if (Properties.ContainsKey(key))
                return Properties[key];
            return XControl.FindXmlElement(key);
        }
    }
}
