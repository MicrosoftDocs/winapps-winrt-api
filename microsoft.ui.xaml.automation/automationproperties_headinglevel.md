---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.HeadingLevel
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.HeadingLevel

<!--
see GetHeadingLevel, and SetHeadingLevel
-->


## -description

Gets or sets the heading level for a UI Automation element.

## -remarks

Heading elements organize the user interface and make it easier to navigate. Some assistive technology (AT) allows users to quickly jump between headings. Headings have a level from 1 to 9.  

The heading level property value is returned by the [GetHeadingLevel](automationproperties_getheadinglevel_1336379589.md) method.

- Type: [AutomationHeadingLevel](../microsoft.ui.xaml.automation.peers/automationheadinglevel.md)
- Identifier field: [HeadingLevelProperty](automationproperties_headinglevelproperty.md)
- Accessor methods: [GetHeadingLevel](automationproperties_getheadinglevel_1336379589.md), [SetHeadingLevel](automationproperties_setheadinglevel_1432143745.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples

```xaml
<TextBlock
    Text="Mouse Options"
    AutomationProperties.HeadingLevel="1"/>
</TextBlock>

<StackPanel AutomationProperties.AutomationName="Description of Content"  AutomationProperties.HeadingLevel="1">
    <!-- content here -->
</StackPanel>
```

```csharp
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        AutomationProperties.SetHeadingLevel(this, AutomationHeadingLevel.HeadingLevel3);
    }
}

```
