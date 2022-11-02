---
-api-id: M:Microsoft.Graphics.Display.DisplayInformation.CreateForDisplayId(Microsoft.UI.DisplayId)
-api-type: winrt method
---

# Microsoft.Graphics.Display.DisplayInformation.CreateForDisplayId(Microsoft.UI.DisplayId)

<!--
public static Microsoft.Graphics.Display.DisplayInformation CreateForDisplayId (Microsoft.UI.DisplayId displayId);
-->

## -description

Creates a new [DisplayInformation](displayinformation.md) object for the specified [DisplayId](/windows/windows-app-sdk/api/winrt/microsoft.ui.displayid).

> [!NOTE]
> You must call this method from a thread that has a [Microsoft.UI.Dispatching.DispatcherQueue](/windows/windows-app-sdk/api/winrt/microsoft.ui.dispatching.dispatcherqueue) already running.

## -parameters

### -param displayId

The display monitor identifier for which to create a [DisplayInformation](displayinformation.md).

## -returns

The new [DisplayInformation](displayinformation.md) object.

## -remarks

## -see-also

## -examples
