using System;
using System.Collections.Generic;

namespace TreeStructureTest.TreeMenu
{
    internal class TreeMenuItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; } = 0;

        public int Level { get; set; }

        public List<TreeMenuItem> Childs { get; set; }

        public void Print()
        {
            var indentationStrategy = new IndentationStrategy { Item = this };
            Console.WriteLine($"{indentationStrategy.Indentation}- {Name}");
            if (Childs != null && Childs.Count > 0)
            {
                foreach (var child in Childs)
                {
                    child.Print();
                }
            }
        }
    }
}
