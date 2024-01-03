using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DataTemplateExamples
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

//<Snippet2_CS>
private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    ListViewItem lvi = ((sender as ListView).SelectedItem as ListViewItem);
    SelectDataTemplate(lvi.Content);
}

private void SelectDataTemplate(object value)
{
    string numberStr = value as string;

    if (numberStr != null)
    {
        int num;

        try
        {
            num = Convert.ToInt32(numberStr);
        }
        catch
        {
            return;
        }

        DataTemplate template;

        // Select one of the DataTemplate objects, based on the 
        // value of the selected item in the ListView.
        if (num % 2 != 0)
        {
            template = rootStackPanel.Resources["oddNumberTemplate"] as DataTemplate;
        }
        else
        {
            template = rootStackPanel.Resources["evenNumberTemplate"] as DataTemplate;
        }

        selectedItemDisplay.Child = template.LoadContent() as UIElement;
        TextBlock tb = FindVisualChild<TextBlock>(selectedItemDisplay);
        tb.Text = numberStr;
    }
}

private childItem FindVisualChild<childItem>(DependencyObject obj)
    where childItem : DependencyObject
{
    for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
    {
        DependencyObject child = VisualTreeHelper.GetChild(obj, i);

        if (child != null && child is childItem)
        {
            return (childItem)child;
        }
        else
        {
            childItem childOfChild = FindVisualChild<childItem>(child);
            if (childOfChild != null)
                return childOfChild;
        }
    }
    return null;
}
//</Snippet2_CS>
    }

//<Snippet1_CS>
public class Customer
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Address { get; set; }

    public Customer(String firstName, String lastName, String address)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = address;
    }

}

public class Customers : ObservableCollection<Customer>
{
    public Customers()
    {
        Add(new Customer("Michael", "Anderberg",
                "12 North Third Street, Apartment 45"));
        Add(new Customer("Chris", "Ashton",
                "34 West Fifth Street, Apartment 67"));
        Add(new Customer("Seo-yun", "Jun",
                "56 East Seventh Street, Apartment 89"));
        Add(new Customer("Guido", "Pica",
                "78 South Ninth Street, Apartment 10"));
    }

}
//</Snippet1_CS>
}
