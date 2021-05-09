using System.Collections.Generic;
using HierarchicalMenu.Extensions;

namespace HierarchicalMenu 
{
    public static class TreeFormatter
    {
        public static List<string> FormatNodesForDisplay(ITreeGenerator treeGenerator)
        {
            var fullHiearchicalTree = treeGenerator.GenerateNodes();
            return FormatNodesForDisplay(fullHiearchicalTree);
        }

        private static List<string> FormatNodesForDisplay(List<TreeNode<string>> treeNodes,List<string> mappedNodes = null)
        {
            if(mappedNodes == null)
            {
                mappedNodes = new List<string>();
            }

            foreach (var t in treeNodes)
            {
                mappedNodes.Add($"{t.ParentLevel.GetIndentation()}-{t.Item}");
                mappedNodes.AddRange(FormatNodesForDisplay(t.GetChildren()));
            }

            return mappedNodes;
        }
    }
}
