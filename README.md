# How to Bind a List in WinForms ComboDropDown Control
## Overview
The ComboDropDown control is similar to a combo box but allows hosting any control in its dropdown area. You cannot bind a list directly to the ComboDropDown. Instead, you can bind the list to a ListBox and host that ListBox in the dropdown using the PopupControl property.

## Implementation Example

```C#
public Form1()
{
    InitializeComponent();
    this.listBox1.DataSource = this.GetData();
    this.comboDropDown1.PopupControl = listBox1;
}

private List<string> GetData()
{
    List<string> list = new List<string>
    {
        "Alaska",
        "Arizona",
        "Colorado",
        "Indiana",
        "Iowa",
        "Kansas",
        "Kentucky",
        "Louisiana",
        "Maine",
        "Maryland",
        "Massachusetts",
        "Michigan",
        "Minnesota"
    };
    return list;
}
```
## Reference
For more details please refer the KB article: [How to bind a list on winforms ComboBoxDropDown](https://www.syncfusion.com/kb/11662/how-to-bind-a-list-in-winforms-combodropdown-control)

## Output
![List binding in WinForms ComboDropDown](ComboBoxDropDown/ComboBoxDropDownSample/Image/Binding%20items%20to%20ComboBox.png)

