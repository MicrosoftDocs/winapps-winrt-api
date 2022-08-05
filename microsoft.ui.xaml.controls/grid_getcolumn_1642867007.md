---
-api-id: M:Microsoft.UI.Xaml.Controls.Grid.GetColumn(Microsoft.UI.Xaml.FrameworkElement)
-api-type: winrt method
---

<!-- Method syntax
public int GetColumn(Windows.UI.Xaml.FrameworkElement element)
-->

# Microsoft.UI.Xaml.Controls.Grid.GetColumn

## -description
Gets the value of the [Grid.Column](grid_column.md) XAML attached property from the specified [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md).

## -parameters
### -param element
The element from which to read the property value.

## -returns
The value of the [Grid.Column](grid_column.md) XAML attached property on the target element. This is a zero-based index.

## -remarks
This method is a utility method for the property system, and isn't used in most app scenarios. In most cases you set the [Grid.Column](grid_column.md) XAML attached property in XAML and won't need this method. For more info, see the [Grid.Column](grid_column.md) XAML attached property.

## -examples
The following example shows how to get the row and column of the element that raised an event.

[!code-xaml[1](../microsoft.ui.xaml.controls.primitives/code/GridGetSet/csharp/Page.xaml#Snippet1)]

[!code-csharp[2](../microsoft.ui.xaml.controls.primitives/code/GridGetSet/csharp/Page.xaml.cs#Snippet2)]

## -see-also

[Grid.Column](grid_column.md), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)
