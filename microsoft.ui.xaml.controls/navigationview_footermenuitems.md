---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.FooterMenuItems
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NavigationView.FooterMenuItems

<!--
public System.Collections.Generic.IList<object> FooterMenuItems { get; }
-->


## -description
Gets the list of objects to be used as navigation items in the footer menu.

## -property-value
The collection of menu items displayed in the footer section of the NavigationView. The default is an empty collection.

## -remarks
FooterMenuItems participates in the same selection model as [NavigationView.MenuItems](navigationview_menuitems.md). Therefore, only one [NavigationViewItem](navigationviewitem.md) within the NavigationView can be selected at a time, whether it is in the main menu items or footer menu items. 

FooterMenuItems will be displayed above the Settings Item by default. To remove the Settings item, set the `IsSettingsVisible` property to `false`.

## -see-also
[NavigationView](navigationview.md)

## -examples

## Add footer menu items in markup

```xaml
<NavigationView>

    <NavigationView.MenuItems>
        <NavigationViewItem Content="Browse" Icon="Library" />
        <NavigationViewItem Content="Track an Order" Icon="Map" />
        <NavigationViewItem Content="Order History" Icon="Tag" />
    </NavigationView.MenuItems>

    <NavigationView.FooterMenuItems>
        <NavigationViewItem Content="Account" Icon="Contact" />
        <NavigationViewItem Content="Your Cart" Icon="Shop" />
        <NavigationViewItem Content="Help" Icon="Help" />
    </NavigationView.FooterMenuItems>
    
</NavigationView>
```
