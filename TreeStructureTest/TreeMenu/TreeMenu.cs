using System.Collections.Generic;

namespace TreeStructureTest.TreeMenu
{
    internal class TreeMenu
    {
        public List<TreeMenuItem> Tree { get; set; }

        public TreeMenu()
        {
        }

        public void Print()
        {
            foreach (var item in Tree)
            {
                item.Print();
            }
        }
    }
}
