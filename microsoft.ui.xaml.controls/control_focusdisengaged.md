---
-api-id: E:Microsoft.UI.Xaml.Controls.Control.FocusDisengaged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler FocusDisengaged<Windows.UI.Xaml.Controls.Control,  Windows.UI.Xaml.Controls.FocusDisengagedEventArgs>
-->

# Microsoft.UI.Xaml.Controls.Control.FocusDisengaged

## -description

Occurs as focus is released from the control when the user presses the B/Back button on an Xbox controller.

## -xaml-syntax

```xaml
<control FocusDisengaged="eventhandler"/>
```

## -remarks

When the [IsFocusEngagementEnabled](control_isfocusengagementenabled.md) property is set to **true**, it marks the control as requiring focus engagement. This means that the user must press the A/Select button to "engage" the control and interact with it. When they are finished, they can press the B/Back button to disengage the control and navigate away from it.

Focus engagement makes it easier to use an Xbox controller to interact with an app. Setting focus engagement does not affect keyboard or other input devices. For more info, see [Focus engagement](/windows/apps/design/input/gamepad-and-remote-interactions#focus-engagement).

## -examples

## -see-also

[FocusDisengagedEventArgs](focusdisengagedeventargs.md), [IsFocusEngaged](control_isfocusengaged.md), [FocusEngaged](control_focusengaged.md), [Focus engagement](/windows/apps/design/input/gamepad-and-remote-interactions#focus-engagement), [XY focus navigation and interaction](/windows/apps/design/input/gamepad-and-remote-interactions#xy-focus-navigation-and-interaction)
