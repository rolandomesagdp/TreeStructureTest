using System.Collections.Generic;
using System.Linq;

namespace TreeStructureTest.TreeMenu
{
    internal class TreeMenuFactory
    {
        public List<TreeMenuItem> OrganizedItems { get; set; }

        public List<TreeMenuItem> SourceItems { get; set; }

        public TreeMenu TreeMenu { get; set; }

        public TreeMenuFactory(List<TreeMenuItem> sourceItems)
        {
            SourceItems = sourceItems;
        }
        public TreeMenuFactory Create()
        {
            var treeFirstLevelItems = GetFirstLevelItems();

            foreach (var treeItem in treeFirstLevelItems)
            {
                BuildChilds(treeItem);
            }

            TreeMenu = new TreeMenu { Tree = treeFirstLevelItems };

            return this;
        }

        private void BuildChilds(TreeMenuItem item)
        {
            item.Childs = GetChilds(item.Id);
            if (item.Childs != null && item.Childs.Count > 0)
            {
                foreach (var child in item.Childs)
                {
                    BuildChilds(child);
                }
            }
        }

        private List<TreeMenuItem> GetFirstLevelItems()
        {
            return SourceItems.Where(x => x.Level == 1).ToList();
        }

        private List<TreeMenuItem> GetChilds(int parentId)
        {
            var itemChilds = SourceItems.Where(x => x.ParentId == parentId && x.Level > 1).ToList();
            return itemChilds.Count > 0 ? itemChilds : null;
        }
    }
}
