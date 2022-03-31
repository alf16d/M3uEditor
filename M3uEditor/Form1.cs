using M3u;
using System.Collections.Generic;
using System.Linq;

namespace M3uEditor
{
    public partial class Form1 : Form
    {
        private M3uFile _m3uFile = null;

        public Form1()
        {
            InitializeComponent();

            list1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            list1.Columns[0].Width = list1.Width - 14;

            list2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            list2.Columns[0].Width = list2.Width - 40;
        }

        private void OnOpenFileClick(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "M3u files (*.m3u)|*.m3u"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _m3uFile = new M3uFile(fileDialog.FileName);
                _m3uFile.Load();
                _m3uFile.GroupEntries();

                list1.Items.Clear();
                list2.Items.Clear();

                list1.Tag = _m3uFile.groups;

                foreach (var group in _m3uFile.groups)
                {
                    var item = new ListViewItem(group.Name);
                    item.Tag = group;

                    list1.Items.Add(item);
                }
            }
        }

        private void OnSaveFileClick(object sender, EventArgs e)
        {
            _m3uFile.Save();
        }

        private void OnSaveAsFileClick(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog
            {
                Filter = "M3u files (*.m3u)|*.m3u"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _m3uFile.SaveAs(fileDialog.FileName);
            }
        }

        private void list1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var group = e.Item.Tag as M3uGroup;

                if (group != null)
                {
                    list2.Items.Clear();
                    list2.Tag = group.entries;

                    foreach (var entry in group.entries)
                    {
                        var item = new ListViewItem(entry.Title);
                        item.Tag = entry;
                        list2.Items.Add(item);
                    }
                }
            }
            else
            {
                list2.Tag = null;
                list2.Items.Clear();
            }
        }
    }
}