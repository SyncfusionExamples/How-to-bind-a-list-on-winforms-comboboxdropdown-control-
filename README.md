# How-to-bind-a-list-on-winforms-comboboxdropdown-control-
This sample demonstrates how to bind a List to the comboboxdropdown control. 

## Data Binding in ComboBox
The data source can be bound by using the [DataSource](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.ListView.SfComboBox.html#Syncfusion_WinForms_ListView_SfComboBox_DataSource) property. The following properties controls the data binding:

* `DisplayMember`: To display the underlying datasource for [Windows Forms ComboBox](https://www.syncfusion.com/winforms-ui-controls/combobox).
* `ValueMember`: To use as the actual value for the items. 

# C#
        private void DropDownListView_DrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            bool isEnableDraw = (this.sfComboBox1.ComboBoxMode == ComboBoxMode.MultiSelection && this.sfComboBox1.AllowSelectAll && this.sfComboBox1.DropDownListView.ShowCheckBoxes && e.ItemIndex == 0) ? false : (e.ItemData as Student).IsDraWSeparator;
            if (isEnableDraw)
            {
                e.Handled = true;
                var listView = sender as SfListView;
                var linearLayout = listView.GetType().GetProperty("LinearLayout", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(listView);
                var items = linearLayout.GetType().GetProperty("Items").GetValue(linearLayout) as List<ListViewItemInfo>;
                var checkBoxStyle = items[e.ItemIndex].GetType().GetProperty("CheckBoxStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                checkBoxStyle.SetValue(items[e.ItemIndex], listView.Style.CheckBoxStyle);
                //Fill the background color of mouse hover item.
                if (e.ItemIndex == mouseHoverItemIndex)
                    e.Graphics.FillRectangle(new SolidBrush(listView.Style.SelectionStyle.HoverBackColor), e.Bounds);
                //Fill the background color of Selecteditem.
                if (sfComboBox1.SelectedIndex == e.ItemIndex)
                    e.Graphics.FillRectangle(new SolidBrush(listView.Style.SelectionStyle.SelectionBackColor), new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 2));
                RectangleF bounds = new RectangleF(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height);
                //Draw the checkbox if MultiSelction and showcheckboxes are enabled.
                if (sfComboBox1.ComboBoxMode == ComboBoxMode.MultiSelection && this.sfComboBox1.DropDownListView.ShowCheckBoxes)
                {
                    CheckBoxPainter.DrawCheckBox(e.Graphics, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2), listView.CheckedItems.Contains(e.ItemData) ? CheckState.Checked : CheckState.Unchecked, listView.Style.CheckBoxStyle);
                    bounds = new RectangleF(e.Bounds.X + 20, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);
                }
                //Draw the listview item text.
                e.Graphics.DrawString((e.ItemData as Student).StudentName, this.Font, new SolidBrush(Color.FromArgb(255, 51, 51, 51)), bounds);
                //Draw the separator line.
                e.Graphics.DrawLine(new Pen(Color.Gray, width: 1) { DashPattern = new[] { 2f, 2f } }, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            }
        }

        int mouseHoverItemIndex = -1;

        private void SfComboBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var list = (sender as SfListView);
            //Get the mouse over item index using mouse location.
            mouseHoverItemIndex = (sender as SfListView).GetRowIndexAtPoint(e.Location);
            list.Invalidate();
        }

![DataBinding Winforms ComboBox](ComboBoxDropDown/ComboBoxDropDownSample/Image/Binding%20items%20to%20ComboBox.png)

For more details please refer [How to bind a list on winforms ComboBoxDropDown](https://www.syncfusion.com/kb/11662/how-to-bind-a-list-in-winforms-combodropdown-control)
