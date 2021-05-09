using System.Collections.Generic;
using System.Linq;
using HierarchicalMenu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TreeFormatterTests
    {
        private List<string> BuildExpectedData()
        {
            var expectedData = new List<string>
            {
                "-Administration",
                " -User Admin",
                "  -Create User",
                "  -Edit User",
                " -Product Admin",
                "  -All Products",
                "   -My Products",
                "  -Create Product",
                " -Order Admin",
                "  -Order Reports",
                "   -Audit Reports",
                "    -Updated Orders",
                "    -Created Orders",
                "  -Create Order",
                "-Reports",
                " -Win Tech Report",
                " -Microsoft Report"
            };

            return expectedData;
        }

        [TestMethod]
        public void GetFormatNodesForDisplay_ShouldReturnValidData()
        {
            //Arrange
            var expectedResult = BuildExpectedData();

            //Act
            var actualResult = TreeFormatter.FormatNodesForDisplay(new TupleTreeGenerator()).Except(expectedResult).ToList();

            //Assert
            Assert.IsTrue(actualResult.Count == 0);
        }
    }
}
