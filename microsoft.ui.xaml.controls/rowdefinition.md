---
-api-id: T:Microsoft.UI.Xaml.Controls.RowDefinition
-api-type: winrt class
---

<!-- Class syntax.
public class RowDefinition : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.IRowDefinition
-->

# Microsoft.UI.Xaml.Controls.RowDefinition

## -description
Defines row-specific properties that apply to [Grid](grid.md) elements.

## -xaml-syntax
```xaml
<RowDefinition .../>

```


## -remarks

## -examples
The following example uses three [ColumnDefinitions](grid_columndefinitions.md) and three [RowDefinitions](grid_rowdefinitions.md) to create a grid that has nine cells, such as in a worksheet. Each cell contains a [TextBlock](textblock.md) element that represents data, and the top row contains a [TextBlock](textblock.md) with the [ColumnSpan](grid_columnspan.md) property applied.



[!code-xaml[ColumnDefinitionClassXAML](../microsoft.ui.xaml.controls/code/ColumnDefinitionClassXAMLSample/csharp/Page.xaml#SnippetColumnDefinitionClassXAML)]

## -see-also
[DependencyObject](../microsoft.ui.xaml/dependencyobject.md)
