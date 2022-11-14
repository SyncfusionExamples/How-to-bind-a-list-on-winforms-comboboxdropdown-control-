# How-to-bind-a-list-on-winforms-comboboxdropdown-control-
This sample demonstrates how to bind a List to the comboboxdropdown control. 

## Data Binding in ComboBox
The data source can be bound by using the [DataSource](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.ListView.SfComboBox.html#Syncfusion_WinForms_ListView_SfComboBox_DataSource) property. The following properties controls the data binding:

* `DisplayMember`: To display the underlying datasource for [Windows Forms ComboBox](https://www.syncfusion.com/winforms-ui-controls/combobox).
* `ValueMember`: To use as the actual value for the items. 

{% tabs %}
{% highlight c# %}
//Bind the data source to combo box control
List<State> list = GetData();
sfComboBox1.DataSource = list;
//Bind the Display member and Value member to the data source
sfComboBox1.DisplayMember = "LongName";
sfComboBox1.ValueMember = "ShortName";

List<State> GetData()
{
    List<State> states = new List<State>();
    states.Add(new State("Alaska", "AK"));
    states.Add(new State("Arizona", "AZ"));
    states.Add(new State("Colorado", "CO"));
    return states;
}

public class State
{
    private string shortName;
    private string longName;

    public State(string LongName, string ShortName)
    {
        this.longName = LongName;
        this.shortName = ShortName;
    }

    public string ShortName
    {
        get { return shortName; }
    }

    public string LongName
    {
        get { return longName; }
    }
}

{% endhighlight %}

![DataBinding Winforms ComboBox](ComboBoxDropDown/ComboBoxDropDownSample/Image/Binding%20items%20to%20ComboBox.png)

For more details please refer [How to bind a list on winforms ComboBoxDropDown](https://www.syncfusion.com/kb/11662/how-to-bind-a-list-in-winforms-combodropdown-control)