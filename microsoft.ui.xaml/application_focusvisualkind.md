---
-api-id: P:Microsoft.UI.Xaml.Application.FocusVisualKind
-api-type: winrt property
---

<!-- Property syntax
public Microsoft.UI.Xaml.FocusVisualKind FocusVisualKind { get;  set; }
-->

# Microsoft.UI.Xaml.Application.FocusVisualKind

## -description

Gets or sets the type of visual feedback that an app can use to indicate the UI element that has focus.

## -property-value

The type of visual feedback used to indicate the UI element that has focus. The default value is [HighVisibility](focusvisualkind.md).

## -remarks

> This property is valid only for input devices that can generate key events, such as a keyboard or game controller.

[HighVisibility](focusvisualkind.md) focus visuals are rendered with an outer (primary) and inner (secondary) border.

For more info, see:

+ [FocusVisualPrimaryBrush](frameworkelement_focusvisualprimarybrush.md)
+ [FocusVisualSecondaryBrush](frameworkelement_focusvisualsecondarybrush.md)
+ [FocusVisualPrimaryThickness](frameworkelement_focusvisualprimarythickness.md)
+ [FocusVisualSecondaryThickness](frameworkelement_focusvisualsecondarythickness.md)

## -examples

## -see-also
