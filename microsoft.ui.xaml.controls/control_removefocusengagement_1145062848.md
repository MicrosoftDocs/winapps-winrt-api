---
-api-id: M:Microsoft.UI.Xaml.Controls.Control.RemoveFocusEngagement
-api-type: winrt method
---

<!-- Method syntax
public void RemoveFocusEngagement()
-->

# Microsoft.UI.Xaml.Controls.Control.RemoveFocusEngagement

## -description

Releases the control from focus constraints that support game controller interactions (where [IsFocusEngaged](control_isfocusengaged.md) is true).

## -remarks

When the [IsFocusEngagementEnabled](control_isfocusengagementenabled.md) property is set to **true**, it marks the control as requiring focus engagement. This means that the user must press the A/Select button to "engage" the control and interact with it. When they are finished, they can press the B/Back button to disengage the control and navigate away from it. You can call RemoveFocusEngagement to programmatically disengage a control.

Focus engagement makes it easier to use a game controller to interact with an app. Setting focus engagement does not affect keyboard or other input devices. For more info, see [Focus engagement](/windows/apps/design/input/gamepad-and-remote-interactions#focus-engagement).

## -examples

## -see-also

[FocusEngaged](control_focusengaged.md), [FocusEngagedEventArgs](focusengagedeventargs.md), [FocusDisengaged](control_focusdisengaged.md), [FocusDisengagedEventArgs](focusdisengagedeventargs.md), [Focus engagement](/windows/apps/design/input/gamepad-and-remote-interactions#focus-engagement), [XY focus navigation and interaction](/windows/apps/design/input/gamepad-and-remote-interactions#xy-focus-navigation-and-interaction)
