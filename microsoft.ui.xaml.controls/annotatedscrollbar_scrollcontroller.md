---
-api-id: P:Microsoft.UI.Xaml.Controls.AnnotatedScrollBar.ScrollController
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.AnnotatedScrollBar.ScrollController

<!--
public Microsoft.UI.Xaml.Controls.Primitives.IScrollController ScrollController { get; }
-->


## -description

Gets an interface that exposes `IScrollController` members.

## -property-value

An interface that exposes `IScrollController` members.

## -remarks

Use this property to connect the `AnnotatedScrollBar` to properties of type [IScrollController](../microsoft.ui.xaml.controls.primitives/iscrollcontroller.md), as shown in the example section.

## -see-also

## -examples

This example shows how to connect an `AnnotatedScrollBar` to the [VerticalScrollController](itemsview_verticalscrollcontroller.md) property of an [ItemsView](itemsview.md).

```xaml
<Grid ColumnDefinitions="*,Auto">
    <ItemsView VerticalScrollController="{x:Bind annotatedScrollBar.ScrollController}"/>
    <AnnotatedScrollBar x:Name="annotatedScrollBar" Grid.Column="1"/>
</Grid>
```
