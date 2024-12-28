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
                case "StatusBarItem":
                    ProcessStatusBarItemNode(node);
                    break;
                case "ScrollViewer":
                    ProcessScrollViewerNode(node);
                    break;
                case "GroupItem":
                    ProcessGroupItemNode(node);
                    break;
                case "ListBoxItem":
                    ProcessListBoxItemNode(node);
                    break;
                case "ComboBoxItem":
                    ProcessComboBoxItemNode(node);
                    break;
                case "ListViewItem":
                    ProcessListViewItemNode(node);
                    break;
                case "RepeatButton":
                    ProcessRepeatButtonNode(node);
                    break;
                case "ToggleButton":
                    ProcessToggleButtonNode(node);
                    break;
                case "CheckBox":
                    ProcessCheckBoxNode(node);
                    break;
                case "RadioButton":
                    ProcessRadioButtonNode(node);
                    break;
                case "GridViewColumnHeader":
                    ProcessGridViewColumnHeaderNode(node);
                    break;
                case "Expander":
                    ProcessExpanderNode(node);
                    break;
                case "GroupBox":
                    ProcessGroupBoxNode(node);
                    break;
                case "TabItem":
                    ProcessTabItemNode(node);
                    break;
                case "ListView":
                    ProcessListViewNode(node);
                    break;
                case "TabControl":
                    ProcessTabControlNode(node);
                    break;
                case "MultiSelector":
                    ProcessMultiSelectorNode(node);
                    break;
                case "TreeViewItem":
                    ProcessTreeViewItemNode(node);
                    break;
                case "ToolBar":
                    ProcessToolBarNode(node);
                    break;
                case "MenuItem":
                    ProcessMenuItemNode(node);
                    break;
                case "Menu":
                    ProcessMenuNode(node);
                    break;
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
        public virtual void ProcessStatusBarItemNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessScrollViewerNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessGroupItemNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessListBoxItemNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessComboBoxItemNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessListViewItemNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessRepeatButtonNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessToggleButtonNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessCheckBoxNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessRadioButtonNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessGridViewColumnHeaderNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessExpanderNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessGroupBoxNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessTabItemNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessListViewNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessTabControlNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessMultiSelectorNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessTreeViewItemNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessToolBarNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessMenuItemNode(XXmlNode node)
        {
            // Nothing todo
        }
        public virtual void ProcessMenuNode(XXmlNode node)
        {
            // Nothing todo
        }

    }
}

