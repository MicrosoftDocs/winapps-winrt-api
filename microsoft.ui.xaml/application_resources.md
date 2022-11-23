---
-api-id: P:Microsoft.UI.Xaml.Application.Resources
-api-type: winrt property
---

<!-- Property syntax
public Microsoft.UI.Xaml.ResourceDictionary Resources { get;  set; }
-->

# Microsoft.UI.Xaml.Application.Resources

## -description

Gets a collection of application-scoped resources, such as styles, templates, and brushes.

## -xaml-syntax

``` xaml
<Application>
  <Application.Resources>
    oneOrMoreResourceElements
  </Application.Resources>
</Application>
```

## -xaml-values

| Value | Description |
|-----|-----|
| oneOrMoreResourceElements | One or more object elements, each of which creates and defines a resource. Each resource property element within each `ResourceDictionary` must have a unique value for the `x:Key`, which serves as the unique key when values are retrieved from the `ResourceDictionary`. |

## -property-value

A [ResourceDictionary](resourcedictionary.md) object that contains zero or more application-scoped resources.

## -remarks

The resource dictionary model in the Windows Runtime supports many of the XAML resource concepts you may be familiar with if you have created applications using Windows Presentation Foundation (WPF) or .NET MAUI. For more info, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

The resources you define in the [ResourceDictionary](resourcedictionary.md) that fills the `Application.Resources` property element are available for retrieval from any page of your app. This is advantageous if many of your app's pages are all using the same resource. For example, if you have a [SolidColorBrush](../microsoft.ui.xaml.media/solidcolorbrush.md) resource that you're using for color schemes in your app's UI, and that color is used on most of your pages, it makes sense to declare that [SolidColorBrush](../microsoft.ui.xaml.media/solidcolorbrush.md) in the `Application.Resources` used for `Application.Resources`.

When you add resources to `Application.Resources`, add them either before or after any existing `ResourceDictionary.MergedResources`. The rules of XAML don't allow you to put content on both sides of a property element tag. For more info, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

## -examples

This example shows how to declare an app-specific resource (this one creates a common converter class instance that comes from starting templates). Then it adds an [Application.MergedDictionaries](resourcedictionary_mergeddictionaries.md) property element with [ResourceDictionary](resourcedictionary.md) elements within, each referencing a XAML file by **URI** as the [Source](resourcedictionary_source.md).

```xaml
<Application.Resources>
    <ResourceDictionary>
      <common:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter"/> 
      <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="rd1.xaml" />
        <ResourceDictionary Source="rd2.xaml" />
      </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
  </Application.Resources>
```

## -see-also

[x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary), [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension), [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources)
