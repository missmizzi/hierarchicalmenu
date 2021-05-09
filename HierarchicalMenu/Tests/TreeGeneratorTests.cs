using HierarchicalMenu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TreeGeneratorTests
    {
        [TestMethod]
        public void GenerateTreeData_ShouldReturnValidData()
        {
            //Act
            var treeGenerator = new TupleTreeGenerator();
            var generatedTreeData = treeGenerator.GenerateNodes();

            //Assert
            Assert.AreEqual(2, generatedTreeData.Count);
        }
    }
}
