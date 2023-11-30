---
-api-id: T:Microsoft.UI.Xaml.Controls.FlipViewItem
-api-type: winrt class
---

<!-- Class syntax.
public class FlipViewItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IFlipViewItem
-->

# Microsoft.UI.Xaml.Controls.FlipViewItem

## -description
Represents the container for an item in a [FlipView](flipview.md) control.

## -xaml-syntax
```xaml
<FlipViewItem .../>
```


## -remarks
The FlipViewItem class provides the container for items displayed in a [FlipView](flipview.md) control. You populate the [FlipView](flipview.md) by adding objects directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [FlipView](flipview.md), a FlipViewItem container is created automatically for each item in the collection.

You can specify the look of the FlipViewItem by setting the [FlipView](flipview.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../microsoft.ui.xaml/style.md) with a [TargetType](../microsoft.ui.xaml/style_targettype.md) of FlipViewItem.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

<!--Windows Blue bug 454560-->


> [!NOTE]
> In an app compiled for Windows 8.1, FlipViewItem handles pointer focus differently than in an app compiled for Windows 8. + In an app compiled for Windows 8, the event order is [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md) &gt; [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) &gt; [PointerReleased](../microsoft.ui.xaml/uielement_pointerreleased.md). FlipViewItem does not mark the [PointerReleased](../microsoft.ui.xaml/uielement_pointerreleased.md) event as [Handled](../microsoft.ui.xaml.input/pointerroutedeventargs_handled.md).
+ In an app compiled for Windows 8.1, the event order is [PointerPressed](../microsoft.ui.xaml/uielement_pointerpressed.md) &gt; [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md). FlipViewItem marks the [PointerReleased](../microsoft.ui.xaml/uielement_pointerreleased.md) event as [Handled](../microsoft.ui.xaml.input/pointerroutedeventargs_handled.md).


## -examples

## -see-also
[SelectorItem](../microsoft.ui.xaml.controls.primitives/selectoritem.md), [FlipView](flipview.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md)
