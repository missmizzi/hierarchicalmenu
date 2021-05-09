using System.Collections.Generic;
using HierarchicalMenu.Data;

namespace HierarchicalMenu
{
    public class TupleTreeGenerator : ITreeGenerator
    {
        public List<TreeNode<string>> GenerateNodes()
        {
            var menuData = TupleDS.GetMenuData();

            TreeNode<string> rootNode = new TreeNode<string>(string.Empty);
            List<TreeNode<string>> fullTree = new List<TreeNode<string>>();

            foreach (var node in menuData)
            {
                if (string.IsNullOrEmpty(node.Item1))
                {
                    rootNode = new TreeNode<string>(node.Item2);
                    fullTree.Add(rootNode);
                }
                else
                {
                    if (rootNode.Item == node.Item1)
                    {
                        rootNode.AddChild(node.Item2);
                    }
                    else
                    {
                        AddTreeData(node.Item1, node.Item2, rootNode.GetChildren());
                    }
                }
            }

            return fullTree;
        }

        #region Private methods
        private static void AddTreeData(string parentNodeName, string childNodeName, List<TreeNode<string>> parentNodes)
        {
            foreach (var parent in parentNodes)
            {
                if (parent.Item == parentNodeName)
                {
                    parent.AddChild(childNodeName);
                }
                else
                {
                    AddTreeData(parentNodeName, childNodeName, parent.GetChildren());
                }
            }
        }
        #endregion
    }
}
