---
-api-id: T:Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason

<!--
public enum XamlSourceFocusNavigationReason
-->

## -description

Specifies values that represent reasons that a [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) got focus in a desktop application that uses a [DesktopWindowXamlSource](desktopwindowxamlsource.md) object to host XAML-based UI.

## -enum-fields

### -field Programmatic: 0

The focus was set programmatically.

### -field Restore: 1

The focus was restored after a task switch, such as pressing **Alt** + **Tab**.

### -field First: 3

The focus was set in response to the user navigating to the next element by using bidirectional navigation, such as pressing **Tab**.

### -field Last: 4

The focus was set in response to the user navigating to the previous element by using bidirectional navigation, such as pressing **Shift-Tab**.

### -field Left: 7

The focus was set in response to the user navigating **left** by using 4-direction navigation, such as pressing keyboard arrow keys.

### -field Up: 8

The focus was set in response to the user navigating **up** by using 4-direction navigation, such as pressing keyboard arrow keys.

### -field Right: 9

The focus was set in response to the user navigating **right** by using 4-direction navigation, such as pressing keyboard arrow keys.

### -field Down: 10

The focus was set in response to the user navigating **down** by using 4-direction navigation, such as pressing keyboard arrow keys.

## -remarks

## -see-also

[XamlSourceFocusNavigationRequest.Reason](xamlsourcefocusnavigationrequest_reason.md)

## -examples
