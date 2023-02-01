---
-api-id: T:Microsoft.UI.Xaml.Controls.HubSection
-api-type: winrt class
---

<!-- Class syntax.
public class HubSection : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IHubSection
-->

# Microsoft.UI.Xaml.Controls.HubSection

## -description
Represents a single group of content in a [Hub](hub.md).

## -xaml-syntax
```xaml
<HubSection .../>
-or-
<HubSection ...>
  oneOrMoreComponents
</HubSection>
```


## -remarks
You put the content of your [Hub](hub.md) in various HubSection elements. Like the [Hub](hub.md), each HubSection has a [Header](hubsection_header.md) and [HeaderTemplate](hubsection_headertemplate.md) property that you can use to set an optional header for the section. You can also make the section header interactive. Typically, the user can tap an interactive header to navigate to the corresponding app section page. When its [IsHeaderInteractive](hubsection_isheaderinteractive.md) property is **true**, the default header includes a chevron glyph, and "Hover" and "Pressed" visual states, and it raises a [SectionHeaderClick](hub_sectionheaderclick.md) event.

You don't add content directly to a hub section; instead, you define the content of your HubSection in a [DataTemplate](../microsoft.ui.xaml/datatemplate.md). Content can be defined inline, or bound to a data source. Any valid XAML can be used in a hub section.

## -examples
This example shows the basic XAML used to create a [Hub](hub.md) with 3 HubSection s.

```xaml
<Hub Header="News" SectionHeaderClick="SectionHeader_Click">
    <HubSection MinWidth="600" Header="Latest">
        <DataTemplate>
            <Grid>   
                <TextBlock Text="The most recent news will be here." 
                           Style="{ThemeResource BodyTextBlockStyle}"/>
            </Grid>
        </DataTemplate>
    </HubSection>

    <HubSection Header="Tech" IsHeaderInteractive="True"  
                Background="#222222" MinWidth="250">
        <DataTemplate>
            <StackPanel>
                <TextBlock Text="Tech news goes here."
                           Style="{ThemeResource BodyTextBlockStyle}"/>
                <TextBlock Text="Click the header to go to the Tech page."
                           Style="{ThemeResource BodyTextBlockStyle}"/>
            </StackPanel>
        </DataTemplate>
    </HubSection>

    <HubSection Header="Sports" IsHeaderInteractive="True" 
                Background="#444444" MinWidth="250">
        <DataTemplate>
            <StackPanel>
                <TextBlock Text="Sports news goes here."
                           Style="{ThemeResource BodyTextBlockStyle}"/>
                <TextBlock Text="Click the header to go to the Sports page." 
                           Style="{ThemeResource BodyTextBlockStyle}"/>
            </StackPanel>
        </DataTemplate>
    </HubSection>
</Hub>
```



## -see-also
[Control](control.md), [Hub](hub.md), [HubSectionCollection](hubsectioncollection.md), [HubSectionHeaderClickEventArgs](hubsectionheaderclickeventargs.md), [ISemanticZoomInformation](isemanticzoominformation.md), [XAML Hub control sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20Hub%20control%20sample)
