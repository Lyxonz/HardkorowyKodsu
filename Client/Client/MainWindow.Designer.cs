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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTables = new System.Windows.Forms.TabPage();
            this.treeTables = new System.Windows.Forms.TreeView();
            this.tabViews = new System.Windows.Forms.TabPage();
            this.treeViews = new System.Windows.Forms.TreeView();
            this.btnGetDatabaseStructure = new System.Windows.Forms.Button();
            this.btnGetTablesStructure = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabTables.SuspendLayout();
            this.tabViews.SuspendLayout();
            this.SuspendLayout();

            this.tabControl.Controls.Add(this.tabTables);
            this.tabControl.Controls.Add(this.tabViews);
            this.tabControl.Location = new System.Drawing.Point(12, 70);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(410, 329);
            this.tabControl.TabIndex = 0;
 
            this.tabTables.Controls.Add(this.treeTables);
            this.tabTables.Location = new System.Drawing.Point(4, 22);
            this.tabTables.Name = "tabTables";
            this.tabTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabTables.Size = new System.Drawing.Size(402, 303);
            this.tabTables.TabIndex = 0;
            this.tabTables.Text = "Tables";
            this.tabTables.UseVisualStyleBackColor = true;

            this.treeTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTables.Location = new System.Drawing.Point(3, 3);
            this.treeTables.Name = "treeTables";
            this.treeTables.Size = new System.Drawing.Size(396, 297);
            this.treeTables.TabIndex = 0;

            this.tabViews.Controls.Add(this.treeViews);
            this.tabViews.Location = new System.Drawing.Point(4, 22);
            this.tabViews.Name = "tabViews";
            this.tabViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabViews.Size = new System.Drawing.Size(402, 303);
            this.tabViews.TabIndex = 1;
            this.tabViews.Text = "Views";
            this.tabViews.UseVisualStyleBackColor = true;

            this.treeViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViews.Location = new System.Drawing.Point(3, 3);
            this.treeViews.Name = "treeViews";
            this.treeViews.Size = new System.Drawing.Size(396, 297);
            this.treeViews.TabIndex = 0;

            this.btnGetDatabaseStructure.Location = new System.Drawing.Point(12, 12);
            this.btnGetDatabaseStructure.Name = "btnGetDatabaseStructure";
            this.btnGetDatabaseStructure.Size = new System.Drawing.Size(200, 23);
            this.btnGetDatabaseStructure.TabIndex = 1;
            this.btnGetDatabaseStructure.Text = "Get Database Structure";
            this.btnGetDatabaseStructure.UseVisualStyleBackColor = true;
            this.btnGetDatabaseStructure.Click += new System.EventHandler(this.btnGetDatabaseStructure_Click);

            this.btnGetTablesStructure.Location = new System.Drawing.Point(222, 12);
            this.btnGetTablesStructure.Name = "btnGetTablesStructure";
            this.btnGetTablesStructure.Size = new System.Drawing.Size(200, 23);
            this.btnGetTablesStructure.TabIndex = 2;
            this.btnGetTablesStructure.Text = "Get Tables Structure";
            this.btnGetTablesStructure.UseVisualStyleBackColor = true;
            this.btnGetTablesStructure.Click += new System.EventHandler(this.btnGetTablesStructure_Click);

            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnGetTablesStructure);
            this.Controls.Add(this.btnGetDatabaseStructure);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Hardkorowy Kodsu";
            this.tabControl.ResumeLayout(false);
            this.tabTables.ResumeLayout(false);
            this.tabViews.ResumeLayout(false);
            this.ResumeLayout(false);
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
