namespace HKClient
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabTables = new TabPage();
            treeTables = new TreeView();
            tabViews = new TabPage();
            treeViews = new TreeView();
            btnGetDatabaseStructure = new Button();
            btnGetTablesStructure = new Button();
            tabControl.SuspendLayout();
            tabTables.SuspendLayout();
            tabViews.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabTables);
            tabControl.Controls.Add(tabViews);
            tabControl.Location = new Point(12, 41);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(576, 447);
            tabControl.TabIndex = 0;
            // 
            // tabTables
            // 
            tabTables.Controls.Add(treeTables);
            tabTables.Location = new Point(4, 24);
            tabTables.Name = "tabTables";
            tabTables.Padding = new Padding(3);
            tabTables.Size = new Size(568, 419);
            tabTables.TabIndex = 0;
            tabTables.Text = "Tables";
            tabTables.UseVisualStyleBackColor = true;
            // 
            // treeTables
            // 
            treeTables.Dock = DockStyle.Fill;
            treeTables.Location = new Point(3, 3);
            treeTables.Name = "treeTables";
            treeTables.Size = new Size(562, 413);
            treeTables.TabIndex = 0;
            // 
            // tabViews
            // 
            tabViews.Controls.Add(treeViews);
            tabViews.Location = new Point(4, 24);
            tabViews.Name = "tabViews";
            tabViews.Padding = new Padding(3);
            tabViews.Size = new Size(568, 390);
            tabViews.TabIndex = 1;
            tabViews.Text = "Views";
            tabViews.UseVisualStyleBackColor = true;
            // 
            // treeViews
            // 
            treeViews.Dock = DockStyle.Fill;
            treeViews.Location = new Point(3, 3);
            treeViews.Name = "treeViews";
            treeViews.Size = new Size(562, 384);
            treeViews.TabIndex = 0;
            // 
            // btnGetDatabaseStructure
            // 
            btnGetDatabaseStructure.Location = new Point(12, 12);
            btnGetDatabaseStructure.Name = "btnGetDatabaseStructure";
            btnGetDatabaseStructure.Size = new Size(200, 23);
            btnGetDatabaseStructure.TabIndex = 1;
            btnGetDatabaseStructure.Text = "Get Database Structure";
            btnGetDatabaseStructure.UseVisualStyleBackColor = true;
            btnGetDatabaseStructure.Click += btnGetDatabaseStructure_Click;
            // 
            // btnGetTablesStructure
            // 
            btnGetTablesStructure.Location = new Point(222, 12);
            btnGetTablesStructure.Name = "btnGetTablesStructure";
            btnGetTablesStructure.Size = new Size(200, 23);
            btnGetTablesStructure.TabIndex = 2;
            btnGetTablesStructure.Text = "Get Tables Structure";
            btnGetTablesStructure.UseVisualStyleBackColor = true;
            btnGetTablesStructure.Click += btnGetTablesStructure_Click;
            // 
            // MainWindow
            // 
            ClientSize = new Size(600, 500);
            Controls.Add(btnGetTablesStructure);
            Controls.Add(btnGetDatabaseStructure);
            Controls.Add(tabControl);
            MinimumSize = new Size(600, 500);
            Name = "MainWindow";
            Text = "Hardkorowy Kodsu";
            tabControl.ResumeLayout(false);
            tabTables.ResumeLayout(false);
            tabViews.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTables;
        private System.Windows.Forms.TreeView treeTables;
        private System.Windows.Forms.TabPage tabViews;
        private System.Windows.Forms.TreeView treeViews;
        private System.Windows.Forms.Button btnGetDatabaseStructure;
        private System.Windows.Forms.Button btnGetTablesStructure;
        #endregion
    }
}
