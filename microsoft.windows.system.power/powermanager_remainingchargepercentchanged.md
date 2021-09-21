---
-api-id: E:Microsoft.Windows.System.Power.PowerManager.RemainingChargePercentChanged
-api-type: winrt event
---

# Microsoft.Windows.System.Power.PowerManager.RemainingChargePercentChanged

<!--
public static event System.EventHandler<object> RemainingChargePercentChanged;
-->


## -description

Raised when the remaining charge percentage of the battery on the device has changed.

## -remarks

To get the remaining charge percentage of the battery in response to this event, use the [RemainingChargePercent](powermanager_remainingchargepercent.md) property. This event corresponds to the **GUID_BATTERY_PERCENTAGE_REMAINING** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[RemainingChargePercent property](powermanager_remainingchargepercent.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


