---
-api-id: P:Microsoft.UI.Xaml.UIElement.IsTapEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsTapEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.IsTapEnabled

## -description

Gets or sets a value that determines whether the [Tapped](uielement_tapped.md) event can originate from that element.

## -xaml-syntax

```xaml
<uiElementIsTapEnabled="bool" />
```

## -property-value

`true` if a [Tapped](uielement_tapped.md) event can originate from this element; otherwise, `false`.

## -remarks

The default is `true` (event enabled). If you set to `false`, the [UIElement](uielement.md) will no longer source the [Tapped](uielement_tapped.md) event. This might be desirable if a parent element such as a list control should instead process the action as a manipulation, or if you want to specify that only some child items emit a `Tapped` event that a parent handles after bubbling.

Another reason to suppress gesture events is if you are handling pointer-level events and don't want gesture recognition logic to impact how the pointer events are fired. For example, if the gesture recognition engine has to test for [Tapped](uielement_tapped.md), then it must delay firing a [PointerMoved](uielement_pointermoved.md) event for small movements, because the user might lift the touch point soon and the input event would normally be gesture-recognized as a tap.

## -examples

## -see-also

[Tapped](uielement_tapped.md), [OnTapped](../microsoft.ui.xaml.controls/control_ontapped_411888825.md), [Handle pointer input](/windows/apps/design/input/handle-pointer-input)
