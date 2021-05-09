using System;
using System.Collections.Generic;

namespace HierarchicalMenu 
{
    public interface ITreeGenerator
    {
        List<TreeNode<string>> GenerateNodes();
    }
}
