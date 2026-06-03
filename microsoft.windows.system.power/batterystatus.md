---
-api-id: T:Microsoft.Windows.System.Power.BatteryStatus
-api-type: winrt enum
---

# Microsoft.Windows.System.Power.BatteryStatus

<!--
public enum BatteryStatus
-->


## -description

Defines values that represent the status of the battery on the device.

## -enum-fields

### -field NotPresent: 0

The battery is not present.

### -field Discharging: 1

The battery is discharging.

### -field Idle: 2

The battery is idle.

### -field Charging: 3

The battery is charging.

## -remarks

Use this enum with the [BatteryStatus](powermanager_batterystatus.md) property to determine the current battery state. A value of `NotPresent` indicates a desktop or device without a battery. The `Idle` state typically means the battery is fully charged and connected to AC power.

## -see-also

[BatteryStatus property](powermanager_batterystatus.md), [BatteryStatusChanged event](powermanager_batterystatuschanged.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples
