---
-api-id: M:Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource.NavigateFocus(Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource.NavigateFocus(Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest)

<!--
public Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationResult NavigateFocus (Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest request);
-->

## -description

Attempts to programmatically give focus to the [DesktopWindowXamlSource](desktopwindowxamlsource.md) in the desktop application.

## -parameters

### -param request

An object that specifies the reason for (along with other optional info) the focus navigation.

## -returns

An object that provides data for the focus navigation request.

## -remarks

When you add a **DesktopWindowXamlSource** to your desktop application, by default the **DesktopWindowXamlSource** does not automatically handle focus navigation via keyboard events such as the **Tab** or arrow keys. Use this method in conjunction with the [GotFocus](desktopwindowxamlsource_gotfocus.md) event to programmatically give focus when the user navigates to the **DesktopWindowXamlSource**.

## -see-also

## -examples
