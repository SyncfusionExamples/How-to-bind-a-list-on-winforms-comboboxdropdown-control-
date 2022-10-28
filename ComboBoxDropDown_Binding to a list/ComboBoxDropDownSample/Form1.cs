using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxDropDownSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = this.GetData();
            this.comboDropDown1.PopupControl = listBox1;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex != -1)
            {
                // Set the combo's text to be the list's Text.
                this.comboDropDown1.TextBox.Text = this.listBox1.SelectedItem.ToString();
                // Close the dropdown.
                this.comboDropDown1.PopupContainer.HidePopup(PopupCloseType.Done);
            }
        }


        private List<string> GetData()
        {
            List<string> list = new List<string>();
            list.Add("Alaska");
            list.Add("Arizona");
            list.Add("Colorado");
            list.Add("Indiana");
            list.Add("Iowa");
            list.Add("Kansas");
            list.Add("Kentucky");
            list.Add("Louisiana");
            list.Add("Maine");
            list.Add("Maryland");
            list.Add("Massachusetts");
            list.Add("Michigan");
            list.Add("Minnesota");
            return list;
        }
    }
}



