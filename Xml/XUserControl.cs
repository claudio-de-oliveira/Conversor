namespace Conversor.Xml
{
    internal class XUserControl : XContentControl
    {
        public static new string? FindXmlElement(string key)
        {
            if (Properties.ContainsKey(key))
                return Properties[key];
            return XContentControl.FindXmlElement(key);
        }
    }
}
