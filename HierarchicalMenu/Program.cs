using System;

namespace HierarchicalMenu 
{
    class Program
    {
        static void Main()
        {
            //In real life, this would have been instantiated according to user selection from menu
            DisplayTreeData(new TupleTreeGenerator());
            Console.ReadKey();
        }

        private static void DisplayTreeData(ITreeGenerator treeGenerator)
        {
            var mappedNodes = TreeFormatter.FormatNodesForDisplay(treeGenerator);
            mappedNodes.ForEach(n => Console.WriteLine(n));
        }
    }
}
