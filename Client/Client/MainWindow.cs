using ApplicationLayer;

namespace HKClient
{
    public partial class MainWindow : Form
    {
        private readonly IDatabaseStructureService _service;
        public MainWindow()
        {
            InitializeComponent();
            _service = new DatabaseStructureService();
        }

        private async void btnGetDatabaseStructure_Click(object sender, EventArgs e)
        {
            try
            {
                var databaseStructure = await _service.GetDatabaseStructureAsync();

                treeTables.Nodes.Clear();
                treeViews.Nodes.Clear();

                foreach (var table in databaseStructure.TableList)
                {
                    treeTables.Nodes.Add(new TreeNode(table));
                }

                foreach (var view in databaseStructure.ViewList)
                {
                    treeViews.Nodes.Add(new TreeNode(view));
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Failed to fetch data from server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGetTablesStructure_Click(object sender, EventArgs e)
        {
            try
            {
                var tablesStructure = await _service.GetTablesStructureAsync();

                treeTables.Nodes.Clear();

                foreach (var table in tablesStructure.Tables)
                {
                    var tableNode = new TreeNode(table.Name);
                    foreach (var column in table.Columns)
                    {
                        tableNode.Nodes.Add(new TreeNode($"{column.Name} ({column.Type})"));
                    }
                    treeTables.Nodes.Add(tableNode);
                }

                treeViews.Nodes.Clear();

                foreach (var view in tablesStructure.Views)
                {
                    var viewNode = new TreeNode(view.Name);
                    foreach (var column in view.Columns)
                    {
                        viewNode.Nodes.Add(new TreeNode($"{column.Name} ({column.Type})"));
                    }
                    treeViews.Nodes.Add(viewNode);
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Failed to fetch data from server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
