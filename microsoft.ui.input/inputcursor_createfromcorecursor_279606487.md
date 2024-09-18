---
-api-id: M:Microsoft.UI.Input.InputCursor.CreateFromCoreCursor(Windows.UI.Core.CoreCursor)
-api-type: winrt method
---

# Microsoft.UI.Input.InputCursor.CreateFromCoreCursor(Windows.UI.Core.CoreCursor)

<!--
public static Microsoft.UI.Input.InputCursor CreateFromCoreCursor (Windows.UI.Core.CoreCursor cursor);
-->

## -description

Creates an [InputCursor](/windows/windows-app-sdk/api/winrt/microsoft.ui.input/inputcursor) instance using the specified [Windows.UI.Core.CoreCursor](/uwp/api/windows.ui.core/corecursor) cursor.

## -parameters

### -param cursor

## -returns

## -remarks

The InputCursor that is created by this method is downcast from an [InputSystemCursor](/windows/windows-app-sdk/api/winrt/microsoft.ui.input/inputsystemcursor) or [InputDesktopNamedResourceCursor](/windows/windows-app-sdk/api/winrt/microsoft.ui.input/inputdesktopnamedresourcecursor) based on the source of the specified [Windows.UI.Core.CoreCursor](/uwp/api/windows.ui.core/corecursor).

## -see-also

## -examples
