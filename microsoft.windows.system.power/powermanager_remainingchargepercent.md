---
-api-id: P:Microsoft.Windows.System.Power.PowerManager.RemainingChargePercent
-api-type: winrt property
---

# Microsoft.Windows.System.Power.PowerManager.RemainingChargePercent

<!--
public static int RemainingChargePercent { get; }
-->


## -description

Gets the remaining charge percentage of the battery on the device.

## -property-value

The remaining charge percentage of the battery.

## -remarks

The granularity varies from system to system but the finest granularity is 1 percent. This property corresponds to the **GUID_BATTERY_PERCENTAGE_REMAINING** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[RemainingChargePercentChanged event](powermanager_remainingchargepercentchanged.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


