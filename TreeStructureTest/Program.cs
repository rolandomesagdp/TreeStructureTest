using System;
using TreeStructureTest.TreeMenu;

namespace TreeStructureTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var treeItemsRepository = new TreeMenuItemsRepository();

            var menuItems = treeItemsRepository.GetAll();

            var treeMenu = new TreeMenuFactory(menuItems).Create().TreeMenu;

            treeMenu.Print();
            Console.ReadLine();
        }
    }
}
