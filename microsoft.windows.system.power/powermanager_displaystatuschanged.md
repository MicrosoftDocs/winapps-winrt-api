---
-api-id: E:Microsoft.Windows.System.Power.PowerManager.DisplayStatusChanged
-api-type: winrt event
---

# Microsoft.Windows.System.Power.PowerManager.DisplayStatusChanged

<!--
public static event System.EventHandler<object> DisplayStatusChanged;
-->


## -description

Raised when the status of the display that is associated with the app's session.

## -remarks

To get the current status of the display in response to this event, use the [DisplayStatus](powermanager_displaystatus.md) property. This event corresponds to the **GUID_SESSION_DISPLAY_STATUS** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[DisplayStatus property](powermanager_displaystatus.md), [DisplayStatus enum](displaystatus.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


