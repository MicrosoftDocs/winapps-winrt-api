---
-api-id: E:Microsoft.Windows.System.Power.PowerManager.UserPresenceStatusChanged
-api-type: winrt event
---

# Microsoft.Windows.System.Power.PowerManager.UserPresenceStatusChanged

<!--
public static event System.EventHandler<object> UserPresenceStatusChanged;
-->


## -description

Raised when the user status associated with the app's session has changed.

## -remarks

To get the current user status in response to this event, use the [UserPresenceStatus](powermanager_userpresencestatus.md) property. This event corresponds to the **GUID_SESSION_USER_PRESENCE** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[UserPresenceStatus property](powermanager_userpresencestatus.md), [UserPresenceStatus enum](userpresencestatus.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


