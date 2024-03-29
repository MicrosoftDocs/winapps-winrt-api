---
-api-id: P:Microsoft.UI.Xaml.UIElement.IsRightTapEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsRightTapEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.IsRightTapEnabled

## -description

Gets or sets a value that determines whether the [RightTapped](uielement_righttapped.md) event can originate from that element.

## -xaml-syntax

```xaml
<uiElement IsRightTapEnabled="bool" />
```

## -property-value

`true` if a [RightTapped](uielement_righttapped.md) event can originate from this element; otherwise, `false`.

## -remarks

The default is `true` (event enabled). If you set to `false`, the [UIElement](uielement.md) will no longer source the [RightTapped](uielement_righttapped.md) event. This might be desirable if a parent element such as a list control should instead process the action as a manipulation, or if you want to specify that only some child items emit a `RightTapped` event that a parent handles after bubbling.

Another reason to suppress gesture events is if you are handling pointer-level events and don't want gesture recognition logic to impact how the pointer events are fired. For example, if the gesture recognition engine has to test for [Tapped](uielement_tapped.md), then it must delay firing a [PointerMoved](uielement_pointermoved.md) event for small movements, because the user might lift the touch point soon and the input event would normally be gesture-recognized as a tap.

You do not need a mouse device to produce a [RightTapped](uielement_righttapped.md) event. A `RightTapped` event is generated if a touch event becomes a [Holding](uielement_holding.md) event when the touch position remained in one place. Even though `Holding` and `RightTapped` might result from the same user touch action, the design guidance for what that event means to an app is different, as is the timing. For more info, see [Handle pointer input](/windows/apps/design/input/handle-pointer-input).

## -examples

## -see-also

[RightTapped](uielement_righttapped.md), [OnRightTapped](../microsoft.ui.xaml.controls/control_onrighttapped_706625126.md), [Handle pointer input](/windows/apps/design/input/handle-pointer-input)
