---
-api-id: P:Microsoft.Windows.System.Power.PowerManager.SystemSuspendStatus
-api-type: winrt property
---

# Microsoft.Windows.System.Power.PowerManager.SystemSuspendStatus

<!--
public static Microsoft.Windows.System.Power.SystemSuspendStatus SystemSuspendStatus { get; }
-->


## -description

Gets the current suspend status of the device.

## -property-value

The current suspend status of the device.

## -remarks

Use this property to detect when the system is entering or resuming from a suspend (sleep/hibernate) state. Your app can use the [SystemSuspendStatusChanged](powermanager_systemsuspendstatuschanged.md) event together with this property to save state before suspend and refresh data after resume.

## -see-also

[SystemSuspendStatusChanged event](powermanager_systemsuspendstatuschanged.md), [SystemSuspendStatus enum](systemsuspendstatus.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


