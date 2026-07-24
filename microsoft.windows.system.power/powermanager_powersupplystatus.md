---
-api-id: P:Microsoft.Windows.System.Power.PowerManager.PowerSupplyStatus
-api-type: winrt property
---

# Microsoft.Windows.System.Power.PowerManager.PowerSupplyStatus

<!--
public static Microsoft.Windows.System.Power.PowerSupplyStatus PowerSupplyStatus { get; }
-->


## -description

Gets the current power supply status of the device.

## -property-value

The current power supply status of the device.

## -remarks

Use this property to determine whether the power supply is connected and providing adequate power. Subscribe to the [PowerSupplyStatusChanged](powermanager_powersupplystatuschanged.md) event to be notified when this value changes.

## -see-also

[PowerSupplyStatusChanged event](powermanager_powersupplystatuschanged.md), [PowerSupplyStatus enum](powersupplystatus.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


