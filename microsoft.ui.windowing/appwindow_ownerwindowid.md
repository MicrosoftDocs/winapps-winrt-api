---
-api-id: P:Microsoft.UI.Windowing.AppWindow.OwnerWindowId
-api-type: winrt property
---

# Microsoft.UI.Windowing.AppWindow.OwnerWindowId

<!--
public Microsoft.UI.WindowId OwnerWindowId { get; }
-->


## -description

Gets the identifier of the owner of this window; or 0 if not owned.

## -property-value

The identifier of the owner of this window; 0 if not owned.

## -remarks

If you created this window an owned window by using the [Create](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindow.create) method overload that has a `ownerWindowsId` parameter, this property returns the ID of the owner window.

## -see-also

## -examples


