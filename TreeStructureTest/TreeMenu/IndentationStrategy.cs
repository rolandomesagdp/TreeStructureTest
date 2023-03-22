namespace TreeStructureTest.TreeMenu
{
    internal class IndentationStrategy
    {
        public string Indentation
        {
            get { return CalculateIndentation(); }
        }
        public TreeMenuItem Item { get; set; }

        private string CalculateIndentation()
        {
            if (Item != null)
            {
                var indentation = "";

                for (int i = 0; i <= Item.Level; i++)
                {
                    indentation = $"{indentation} ";
                }

                return indentation;
            }
            else return "";
        }
    }
}
