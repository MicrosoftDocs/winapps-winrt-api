---
-api-id: E:Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource.GotFocus
-api-type: winrt event
---

# Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource.GotFocus

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource,Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSourceGotFocusEventArgs> GotFocus;
-->

## -description

Occurs when the [DesktopWindowXamlSource](desktopwindowxamlsource.md) gets focus in the desktop application (such as when the user presses the **Tab** key while focus is on the element just before the **DesktopWindowXamlSource**).

## -remarks

When you add a **DesktopWindowXamlSource** to your desktop application, by default the **DesktopWindowXamlSource** does not automatically handle focus navigation via keyboard events such as the **Tab** or arrow keys. Call the [NavigateFocus(Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest)](desktopwindowxamlsource_navigatefocus_935751221.md) method to programmatically give focus when the user navigates to the **DesktopWindowXamlSource**.

Handle **GotFocus** event to be notified when user enters the **DesktopWindowXamlSource** via some non-keyboard event, such as a mouse click, and you want to keep the state of the UI in the host desktop application up to date.

## -see-also

## -examples
