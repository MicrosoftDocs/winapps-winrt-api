---
-api-id: M:Microsoft.Graphics.Display.DisplayInformation.CreateForWindowId(Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.Graphics.Display.DisplayInformation.CreateForWindowId(Microsoft.UI.WindowId)

<!--
public static Microsoft.Graphics.Display.DisplayInformation CreateForWindowId (Microsoft.UI.WindowId windowId);
-->

## -description

Creates a new [DisplayInformation](displayinformation.md) object for the specified [WindowId](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowid).

> [!NOTE]
> You must call this method from a thread that has a [Microsoft.UI.Dispatching.DispatcherQueue](/windows/windows-app-sdk/api/winrt/microsoft.ui.dispatching.dispatcherqueue) already running.

## -parameters

### -param windowId

The top-level window identifier for which to create a [DisplayInformation](displayinformation.md).

## -returns

The new [DisplayInformation](displayinformation.md) object.

## -remarks

## -see-also

## -examples
