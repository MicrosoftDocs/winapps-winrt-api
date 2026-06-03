---
-api-id: P:Microsoft.Windows.System.Power.PowerManager.BatteryStatus
-api-type: winrt property
---

# Microsoft.Windows.System.Power.PowerManager.BatteryStatus

<!--
public static Microsoft.Windows.System.Power.BatteryStatus BatteryStatus { get; }
-->


## -description

Gets the current status of the battery on the device.

## -property-value

The current status of the battery.

## -remarks

Use this property to determine whether the device has a battery and whether it is currently charging, discharging, or idle. Subscribe to the [BatteryStatusChanged](powermanager_batterystatuschanged.md) event to be notified when this value changes.

## -see-also

[BatteryStatusChanged event](powermanager_batterystatuschanged.md), [BatteryStatus enum](batterystatus.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


