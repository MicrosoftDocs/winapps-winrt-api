---
-api-id: P:Microsoft.UI.Xaml.Window.CoreWindow
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Core.CoreWindow CoreWindow { get; }
-->

# Microsoft.UI.Xaml.Window.CoreWindow

## -description

Desktop apps always return `null` for this property.

## -property-value

Value is `null` for Desktop apps.

## -remarks

The [Window](window.md) object implements [IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative), through which Desktop apps can get the underlying HWND of the `Window`.

## -examples

## -see-also

[IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative)
