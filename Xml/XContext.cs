namespace Conversor.Xml
{
    public abstract class XContext
    {
/*************  ✨ Codeium Command ⭐  *************/
        /// <summary>
        /// Recursively processes an XML node and its children. 
        /// It first checks if the node has children, and if so, 
        /// calls itself on each child node. After processing all 
        /// children, it calls the ProcessNode method on the 
        /// original node.
        /// </summary>
        /// <param name="xnode">The XXmlNode to process.</param>
/******  2faca636-e525-4300-ad8e-c8d20c866b10  *******/
        public void Process(XXmlNode xnode)
        {
            if (xnode.ChildNodes != null)
                foreach (var node in xnode.ChildNodes)
                    Process(node);

            ProcessNodeInternal(xnode);
        }

/*************  ✨ Codeium Command ⭐  *************/
        /// <summary>
        /// Recursively processes an XML node and its children. 
        /// It first processes all children, and then calls the 
        /// appropriate ProcessXXXNode method based on the node's name.
        /// </summary>
        /// <param name="node">The XXmlNode to process.</param>
/******  9c9c9bf4-20bc-4b90-aa83-fd6a29d61370  *******/
        private void ProcessNodeInternal(XXmlNode node)
        {
            if (node.ChildNodes != null)
                foreach (XXmlNode childNode in node.ChildNodes)
                    ProcessNodeInternal(childNode);

            switch(node.Name) {
                case "Window":
                    ProcessWindowNode(node);
                    break;
                case "UserControl":
                    ProcessUserControlNode(node);
                    break;
                case "ListBox":
                    ProcessListBoxNode(node);
                    break;
                case "ComboBox":
                    ProcessComboBoxNode(node);
                    break;
                case "Label":
                    ProcessLabelNode(node);
                    break;
                case "ButtonBase":
                    ProcessButtonBaseNode(node);
                    break;
                case "Button":
                    ProcessButtonNode(node);
                    break;
                case "TextBoxBase":
                    ProcessTextBoxBaseNode(node);
                    break;
                case "TextBox":
                    ProcessTextBoxNode(node);
                    break;
                case "Panel":
                    ProcessPanelNode(node);
                    break;
                case "Grid":
                    ProcessGridNode(node);
                    break;
                case "Page":
                    ProcessPageNode(node);
                    break;
                case "Image":
                    ProcessImageNode(node);
                    break;
                case "Selector":
                    ProcessSelectorNode(node);
                    break;
                case "ItemsControl":
                    ProcessItemsControlNode(node);
                    break;
                case "Control":
                    ProcessControlNode(node);
                    break;
                case "ContentControl":
                    ProcessContentControlNode(node);
                    break;
                // StatusBarItem
                // ScrollViewer
                // GroupItem
                // ListBoxItem
                // ComboBoxItem
                // ListViewItem
                // Button    
                // /RepeatButton
                // ToggleButton
                // CheckBox
                // RadioButton
                // GridViewColumnHeader
                // Expander
                // GroupBox
                // TabItem
                // ListView
                // ListBox
                // ComboBox
                // TabControl
                // MultiSelector
                // TreeViewItem
                // ToolBar
                // MenuItem
                // Menu
                // 
                default:
                    ProcessDefaultNode(node);
                    break;
            }
        }

        public virtual void ProcessWindowNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessUserControlNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessListBoxNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessComboBoxNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessLabelNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessButtonBaseNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessButtonNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessTextBoxBaseNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessTextBoxNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessPanelNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessGridNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessPageNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessImageNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessSelectorNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessItemsControlNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessControlNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessContentControlNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessDefaultNode(XXmlNode node)
        {
            // Nothing todo
        }
    }
}

