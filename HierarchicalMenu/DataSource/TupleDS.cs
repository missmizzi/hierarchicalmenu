using System.Collections.Generic;

namespace HierarchicalMenu .Data
{
    public class TupleDS
    {
        public static List<(string, string)> GetMenuData()
        {
            var menuData = new List<(string, string)>();

            (string, string) menuItem1 = (null, "Administration");
            (string, string) menuItem2 = ("Administration", "User Admin");
            (string, string) menuItem3 = ("User Admin", "Create User");
            (string, string) menuItem4 = ("User Admin", "Edit User");
            (string, string) menuItem5 = ("Administration", "Product Admin");
            (string, string) menuItem6 = ("Product Admin", "All Products");
            (string, string) menuItem7 = ("All Products", "My Products");
            (string, string) menuItem8 = ("Product Admin", "Create Product");
            (string, string) menuItem9 = ("Administration", "Order Admin");
            (string, string) menuItem10 = ("Order Admin", "Order Reports");
            (string, string) menuItem11 = ("Order Reports", "Audit Reports");
            (string, string) menuItem12 = ("Audit Reports", "Updated Orders");
            (string, string) menuItem13 = ("Audit Reports", "Created Orders");
            (string, string) menuItem14 = ("Order Admin", "Create Order");
            (string, string) menuItem15 = (null, "Reports");
            (string, string) menuItem16 = ("Reports", "Win Tech Report");
            (string, string) menuItem17 = ("Reports", "Microsoft Report");

            menuData.Add(menuItem1);
            menuData.Add(menuItem2);
            menuData.Add(menuItem3);
            menuData.Add(menuItem4);
            menuData.Add(menuItem5);
            menuData.Add(menuItem6);
            menuData.Add(menuItem7);
            menuData.Add(menuItem8);
            menuData.Add(menuItem9);
            menuData.Add(menuItem10);
            menuData.Add(menuItem11);
            menuData.Add(menuItem12);
            menuData.Add(menuItem13);
            menuData.Add(menuItem14);
            menuData.Add(menuItem15);
            menuData.Add(menuItem16);
            menuData.Add(menuItem17);

            return menuData;
        }
    }
}
