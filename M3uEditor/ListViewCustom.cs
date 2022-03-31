using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3uEditor
{
    public class ListViewCustom : ListView
    {
        public ListViewCustom()
        {
            this.FullRowSelect = true;

            this.ListViewItemSorter = new ListViewIndexComparer();

            if (OSFeature.Feature.IsPresent(OSFeature.Themes))
            {
                this.AllowDrop = true;
                this.ItemDrag += new ItemDragEventHandler(myListView_ItemDrag);
                this.DragEnter += new DragEventHandler(myListView_DragEnter);
                this.DragOver += new DragEventHandler(myListView_DragOver);
                this.DragLeave += new EventHandler(myListView_DragLeave);
                this.DragDrop += new DragEventHandler(myListView_DragDrop);
            }
        }

        // Starts the drag-and-drop operation when an item is dragged.
        private void myListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        // Sets the target drop effect.
        private void myListView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        // Moves the insertion mark as the item is dragged.
        private void myListView_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse pointer.
            var targetPoint = this.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = this.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = this.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    this.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    this.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            this.InsertionMark.Index = targetIndex;
        }

        // Removes the insertion mark when the mouse leaves the control.
        private void myListView_DragLeave(object sender, EventArgs e)
        {
            this.InsertionMark.Index = -1;
        }

        // Moves the item to the location of the insertion mark.
        private void myListView_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the index of the insertion mark;
            int targetIndex = this.InsertionMark.Index;

            // If the insertion mark is not visible, exit the method.
            if (targetIndex == -1)
            {
                return;
            } 

            // If the insertion mark is to the right of the item with
            // the corresponding index, increment the target index.
            if (this.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            // Retrieve the dragged item.

            if (e.Data == null)
                return;

            var draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Insert a copy of the dragged item at the target index.
            // A copy must be inserted before the original item is removed
            // to preserve item index values.
            this.Items.Insert(targetIndex, (ListViewItem)draggedItem.Clone());

            // Remove the original copy of the dragged item.
            this.Items.Remove(draggedItem);

            var itemList = Tag as IList;

            var index = itemList.IndexOf(draggedItem.Tag);

            var item1 = itemList[index];
            itemList[index] = itemList[targetIndex];
            itemList[targetIndex] = item1;
        }

        private class ListViewIndexComparer : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x == null || y == null)
                    return 0;

                return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
            }
        }
    }
}
