---
-api-id: E:Microsoft.Windows.System.Power.PowerManager.SystemIdleStatusChanged
-api-type: winrt event
---

# Microsoft.Windows.System.Power.PowerManager.SystemIdleStatusChanged

<!--
public static event System.EventHandler<object> SystemIdleStatusChanged;
-->


## -description

Raised when the system is busy. This indicates that the system will not be moving into an idle state in the near future and that the current time is a good time for components to perform background or idle tasks that would otherwise prevent the computer from entering an idle state.

## -remarks

There is no notification when the system is able to move into an idle state. The idle background task notification does not indicate whether a user is present at the computer.

This event corresponds to the **GUID_IDLE_BACKGROUND_TASK** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


