﻿using System.Xml;
using Conversor.Xml;
using Conversor.Generator;
using Conversor.Flutter;

internal class Program
{
    private static void Main(string[] args)
    {
        // // string[] xmlFiles = ListXmlFiles(args[0]);
        // string[] xmlFiles = ListXmlFiles("/home/claudio/Source/Conversor/ConversorWpfApp");

        // if (args.Length > 0)
        // {
        //     foreach (string caminhoArquivo in xmlFiles)
        //     {
        //         var xml = LerArquivoXml(caminhoArquivo);

        //         XXmlNode xmlNode = ProcessXmlNode(xml);

        //         var xContext = new XFlutterContext();

        //         xContext.Process(xmlNode);
        //     }

        // }

        CodeGenerator.GenerateXContextBase("/home/claudio/Source/Conversor/Conversor/src/Xml/XContextBase.cs");

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