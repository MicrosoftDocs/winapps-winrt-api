---
-api-id: T:Microsoft.UI.Xaml.Controls.ColumnDefinition
-api-type: winrt class
---

<!-- Class syntax.
public class ColumnDefinition : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.IColumnDefinition
-->

# Microsoft.UI.Xaml.Controls.ColumnDefinition

## -description
Defines column-specific properties that apply to [Grid](grid.md) objects.

## -xaml-syntax
```xaml
<ColumnDefinition .../>
```


## -remarks

## -examples
The following example uses three ColumnDefinitionand three [RowDefinition](rowdefinition.md)s to create a grid that has nine cells, such as in a worksheet. Each cell contains a [TextBlock](textblock.md) element that represents data, and the top row contains a [TextBlock](textblock.md) with the [ColumnSpan](grid_columnspan.md) property applied.



[!code-xaml[ColumnDefinitionClassXAML](../microsoft.ui.xaml.controls/code/ColumnDefinitionClassXAMLSample/csharp/Page.xaml#SnippetColumnDefinitionClassXAML)]

## -see-also
[DependencyObject](../microsoft.ui.xaml/dependencyobject.md), [Grid](grid.md), [RowDefinition](rowdefinition.md), [ColumnDefinitions](grid_columndefinitions.md), [RowDefinitions](grid_rowdefinitions.md)
