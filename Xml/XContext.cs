namespace Conversor.Xml
{
    public abstract class XContext
    {
        protected abstract void ProcessNode(XContext context, XXmlNode node);

        public void Process(XContext context, XXmlNode node)
        {
            if (node.ChildNodes != null)
                foreach (var key in node.ChildNodes.Keys)
                    Process(context, node.ChildNodes[key]);

            ProcessNode(context, node);
        }
    }
}