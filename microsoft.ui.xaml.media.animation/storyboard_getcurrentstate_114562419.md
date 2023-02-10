---
-api-id: M:Microsoft.UI.Xaml.Media.Animation.Storyboard.GetCurrentState
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Media.Animation.ClockState GetCurrentState()
-->

# Microsoft.UI.Xaml.Media.Animation.Storyboard.GetCurrentState

## -description
Gets the clock state of the [Storyboard](storyboard.md).

## -returns
One of the enumeration values. Can be: **Active**, **Filling**, or **Stopped**.

## -remarks
This method is useful if you want to modify an animation's properties at runtime, before the animation is started. An animation that is stopped (GetCurrentState returns **ClockState.Stopped**) can still be modified. An animation that is running (GetCurrentState returns either **ClockState.Active** or **ClockState.Filling**) cannot be modified, and you'll get an error if you try.

An animation can have an optional [BeginTime](timeline_begintime.md) value, which modifies when the animation actually starts to affect values compared to when the controlling storyboard is started. Even if the running time has not reached the [BeginTime](timeline_begintime.md) yet, it's illegal to modify the properties of the animation once the storyboard starts it.

## -examples

## -see-also
[GetCurrentTime](storyboard_getcurrenttime_1338472985.md), [Storyboarded animations](/windows/apps/design/motion/storyboarded-animations)
