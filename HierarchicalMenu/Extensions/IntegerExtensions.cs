using System.Text;

namespace HierarchicalMenu .Extensions
{
    public static class IntegerExtensions
    {
        public static string GetIndentation(this int parentLevel)
        {
            var s = new StringBuilder();
            for (int i = 1; i < parentLevel; i++)
            {
                s.Append(" ");
            }

            return s.ToString();
        }
    }
}
