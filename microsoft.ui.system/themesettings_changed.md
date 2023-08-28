---
-api-id: E:Microsoft.UI.System.ThemeSettings.Changed
-api-type: winrt event
---

# Microsoft.UI.System.ThemeSettings.Changed

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.System.ThemeSettings,object> Changed;
-->

## -description

This event is raised when one of the [ThemeSettings](themesettings.md) object's properties has changed.

## -remarks

The **Changed** event will only be raised while the [ThemeSettings](themesettings.md) object is alive. Developers must ensure that applications keep a reference to the object as long as they want to receive the event.

The **Changed** event will only be raised as long as the window represented by [WindowId](../microsoft.ui/windowid.md) is alive (has not yet received [WM_NCDESTROY](/windows/win32/winmsg/wm-ncdestroy)).

## -see-also

[ThemeSettings](themesettings.md), [WindowId](../microsoft.ui/windowid.md), [WM_NCDESTROY](/windows/win32/winmsg/wm-ncdestroy)

## -examples
