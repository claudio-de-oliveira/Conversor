
using System.Xml;
using Conversor.Xml;
using Conversor.Atributos;

internal class Program
{
    static Dictionary<string, object> xmlNodeTypes = [];

    private static void Main(string[] args)
    {
        // string[] xmlFiles = ListXmlFiles(args[0]);
        string[] xmlFiles = ListXmlFiles("/home/claudio/Source/Conversor/ConversorWpfApp");

        // var xsdPath = "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v10.0A\\bin\\NETFX 4.8 Tools\\x64\\xsd.exe";

        if (args.Length > 0)
        {
            foreach (string caminhoArquivo in xmlFiles)
            {
                var xml = LerArquivoXml(caminhoArquivo);

                XXmlNode xmlNode = ProcessXmlNode(xml);

                var xContext = new XFlutterContext();

                xContext.Process(xmlNode);
            }

        }

        return;

    }

    private static string[] ListXmlFiles(string path)
    {
        try
        {
            // Verifica se o caminho existe
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException("O caminho não existe.");
            }

            // Lista todos os arquivos com extensão XML
            string[] xmlFiles = Directory.GetFiles(path, "*.xaml", SearchOption.AllDirectories);

            return xmlFiles;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao listar arquivos XML: " + ex.Message);
            return [];
        }
    }

    private static XXmlAttribute ProcessXmlAttribute(XmlAttribute attribute)
    {
        return new XXmlAttribute() {
            Name = attribute.Name,
            Value = attribute.Value
        };
    }

    private static XXmlNode ProcessXmlNode(XmlNode node)
    {
        var xnode = new XXmlNode() {
            Name = node.Name,
            Value = node.Value,
        };
        
        if (node.Attributes != null)
            foreach (XmlAttribute xmlAttribute in node.Attributes)
                xnode.Attributes.Add(ProcessXmlAttribute(xmlAttribute));
        if (node.ChildNodes != null)
            foreach (XmlNode childNode in node.ChildNodes)
                xnode.ChildNodes.Add(ProcessXmlNode(childNode));

        return xnode;
    }

    private static XmlDocument LerArquivoXml(string caminhoArquivo)
    {
        using XmlReader reader = XmlReader.Create(caminhoArquivo);
        var xmlDoc = new XmlDocument();
        xmlDoc.Load(reader);
        return xmlDoc;
    }
}
