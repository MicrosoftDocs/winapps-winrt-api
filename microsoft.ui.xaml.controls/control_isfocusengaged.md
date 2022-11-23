---
-api-id: P:Microsoft.UI.Xaml.Controls.Control.IsFocusEngaged
-api-type: winrt property
---

<!-- Property syntax
public bool IsFocusEngaged { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Control.IsFocusEngaged

## -description

Get or sets a value that indicates whether focus is constrained to the control when the user presses the A/Select button on an Xbox controller.

## -xaml-syntax

```xaml
<control IsFocusEngaged="bool"/>
```

## -property-value

**true** if focus is constrained within the control boundaries; otherwise, **false**.

## -remarks

[IsFocusEngagementEnabled](control_isfocusengagementenabled.md) must be **true** and the control must have focus before you set the IsFocusEngaged property to **true**. Otherwise, a runtime exception will occur.

When the [IsFocusEngagementEnabled](control_isfocusengagementenabled.md) property is set to **true**, it marks the control as requiring focus engagement. This means that the user must press the A/Select button to "engage" the control and interact with it. When they are finished, they can press the B/Back button to disengage the control and navigate away from it.

Focus engagement makes it easier to use an Xbox controller to interact with an app. Setting focus engagement does not affect keyboard or other input devices. For more info, see [Focus engagement](/windows/apps/design/input/gamepad-and-remote-interactions#focus-engagement).

## -examples

## -see-also

[FocusEngaged](control_focusengaged.md), [FocusEngagedEventArgs](focusengagedeventargs.md), [FocusDisengaged](control_focusdisengaged.md), [FocusDisengagedEventArgs](focusdisengagedeventargs.md), [Focus engagement](/windows/apps/design/input/gamepad-and-remote-interactions#focus-engagement), [XY focus navigation and interaction](/windows/apps/design/input/gamepad-and-remote-interactions#xy-focus-navigation-and-interaction)
