namespace M3uEditor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openm3uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savem3uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list1 = new M3uEditor.ListViewCustom();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list2 = new M3uEditor.ListViewCustom();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openm3uToolStripMenuItem,
            this.toolStripMenuItem1,
            this.savem3uToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openm3uToolStripMenuItem
            // 
            this.openm3uToolStripMenuItem.Name = "openm3uToolStripMenuItem";
            this.openm3uToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.openm3uToolStripMenuItem.Text = "Open (.m3u)";
            this.openm3uToolStripMenuItem.Click += new System.EventHandler(this.OnOpenFileClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.toolStripMenuItem1.Text = "Save (.m3u)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.OnSaveFileClick);
            // 
            // savem3uToolStripMenuItem
            // 
            this.savem3uToolStripMenuItem.Name = "savem3uToolStripMenuItem";
            this.savem3uToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.savem3uToolStripMenuItem.Text = "Save as...";
            this.savem3uToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAsFileClick);
            // 
            // list1
            // 
            this.list1.AllowDrop = true;
            this.list1.AutoArrange = false;
            this.list1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.list1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list1.FullRowSelect = true;
            this.list1.GridLines = true;
            this.list1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.list1.HideSelection = true;
            this.list1.LabelWrap = false;
            this.list1.Location = new System.Drawing.Point(3, 23);
            this.list1.MultiSelect = false;
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(244, 348);
            this.list1.TabIndex = 0;
            this.list1.UseCompatibleStateImageBehavior = false;
            this.list1.View = System.Windows.Forms.View.Details;
            this.list1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list1_ItemSelectionChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grounp Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 374);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groups";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list2);
            this.groupBox2.Location = new System.Drawing.Point(268, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 374);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channels";
            // 
            // list2
            // 
            this.list2.AllowDrop = true;
            this.list2.AutoArrange = false;
            this.list2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.list2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list2.FullRowSelect = true;
            this.list2.GridLines = true;
            this.list2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.list2.HideSelection = true;
            this.list2.LabelWrap = false;
            this.list2.Location = new System.Drawing.Point(3, 23);
            this.list2.MultiSelect = false;
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(275, 348);
            this.list2.TabIndex = 0;
            this.list2.UseCompatibleStateImageBehavior = false;
            this.list2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Grounp Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 460);
            this.MinimumSize = new System.Drawing.Size(577, 460);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M3uEditor 0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ListViewCustom list1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListViewCustom list2;
        private ColumnHeader columnHeader1;
        private ToolStripMenuItem openm3uToolStripMenuItem;
        private ToolStripMenuItem savem3uToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}