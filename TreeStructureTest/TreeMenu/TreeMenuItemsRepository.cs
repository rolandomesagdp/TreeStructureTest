using System.Collections.Generic;

namespace TreeStructureTest.TreeMenu
{
    internal class TreeMenuItemsRepository
    {
        public List<TreeMenuItem> GetAll()
        {
            var tree = new List<TreeMenuItem>()
            {
                new TreeMenuItem { Id = 0, Name = "Administration", Level = 1 },
                new TreeMenuItem { Id = 1, Name = "User Admin", ParentId = 0, Level = 2 },
                new TreeMenuItem { Id = 2, Name = "Create User", ParentId = 1, Level = 3 },
                new TreeMenuItem { Id = 3, Name = "Edit User", ParentId = 1, Level = 3 },
                new TreeMenuItem { Id = 4, Name = "Product Admin", ParentId = 0, Level = 2 },
                new TreeMenuItem { Id = 5, Name = "All Products", ParentId = 4, Level = 3 },
                new TreeMenuItem { Id = 6, Name = "My Products", ParentId = 5, Level = 4 },
                new TreeMenuItem { Id = 7, Name = "Create Product", ParentId = 4, Level = 4 },
                new TreeMenuItem { Id = 8, Name = "Order Admin", ParentId = 0, Level = 2 },
                new TreeMenuItem { Id = 9, Name = "Order Reports", ParentId = 8, Level = 3 },
                new TreeMenuItem { Id = 10, Name = "Audit Reports", ParentId = 9, Level = 4 },
                new TreeMenuItem { Id = 11, Name = "Updated Orders", ParentId = 10, Level = 5 },
                new TreeMenuItem { Id = 12, Name = "Created Orders", ParentId = 10, Level = 5 },
                new TreeMenuItem { Id = 13, Name = "Create Order", ParentId = 8, Level = 3 },
                new TreeMenuItem { Id = 14, Name = "Reports", Level = 1 },
                new TreeMenuItem { Id = 15, Name = "Win Tech Report", ParentId = 14, Level = 2 },
                new TreeMenuItem { Id = 16, Name = "Microsoft Report", ParentId = 14, Level = 2 }
            };

            return tree;
        }
    }
}
