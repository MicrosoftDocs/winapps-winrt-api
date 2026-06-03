---
-api-id: P:Microsoft.Windows.System.Power.PowerManager.RemainingDischargeTime
-api-type: winrt property
---

# Microsoft.Windows.System.Power.PowerManager.RemainingDischargeTime

<!--
public static System.TimeSpan RemainingDischargeTime { get; }
-->


## -description

Gets the remaining discharge time of the battery on the device.

## -property-value

The remaining discharge time of the battery.

## -remarks

Returns a [TimeSpan](/dotnet/api/system.timespan) representing the estimated time remaining before the battery is fully discharged. This value is meaningful only when the device is running on battery power ([PowerSourceKind](powermanager_powersourcekind.md) is `DC`). Subscribe to the [RemainingDischargeTimeChanged](powermanager_remainingdischargetimechanged.md) event to be notified when this estimate changes.

## -see-also

[RemainingDischargeTimeChanged event](powermanager_remainingdischargetimechanged.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


