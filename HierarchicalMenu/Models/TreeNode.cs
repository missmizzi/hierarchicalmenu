using System.Collections.Generic;

namespace HierarchicalMenu 
{
    public class TreeNode<T>
    {
        private readonly List<TreeNode<T>> Children = new List<TreeNode<T>>();

        public T Item { get; set; }
        public int ParentLevel { get; private set; }

        public TreeNode(T item)
        {
            ParentLevel = 1;
            Item = item;
        }

        public TreeNode<T> AddChild(T item)
        {
            TreeNode<T> nodeItem = new TreeNode<T>(item)
            {
                ParentLevel = ParentLevel + 1
            };
            Children.Add(nodeItem);
            return nodeItem;
        }

        public List<TreeNode<T>> GetChildren()
        {
            return Children;
        }
    }
}
